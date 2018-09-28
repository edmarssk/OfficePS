using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using OfficePS.Models;
using OfficePS.ViewModels;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OfficePS.Controllers
{
    public class HomeController : Controller
    {

        private readonly IHostingEnvironment _environment;
        private readonly IClientesRepositorio _clienteRepositorio;

        public HomeController(IClientesRepositorio clienteRepositorio, IHostingEnvironment environment)
        {
            _clienteRepositorio = clienteRepositorio;
            _environment = environment;
        }
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            ClienteVM clienteVM = new ClienteVM();
            ViewBag.TitleClientes = "Lista de clientes";
            return View(_clienteRepositorio.GetAll());
        }

        public IActionResult Create()
        {
            List<SelectListItem> listItens = new List<SelectListItem>() {
                new SelectListItem(){ Value = "", Text="Selecione..." },
                new SelectListItem(){ Value = "M", Text="Masculino" },
                new SelectListItem(){ Value = "F", Text="Feminino" }
            };
            ViewData["Itens"] = listItens;
           
            return View();
        }

        [HttpPost]
        public IActionResult Create(ClienteVM clienteVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (HttpContext.Request.Form.Files != null && HttpContext.Request.Form.Files.Count > 0)
            {
                var file = HttpContext.Request.Form.Files[0];

                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

                var guidFileName = Convert.ToString(Guid.NewGuid());

                var extension = Path.GetExtension(fileName);

                clienteVM.FotoPerfil = guidFileName + extension;

                fileName = Path.Combine(_environment.WebRootPath, "image") + $@"\perfil\{clienteVM.FotoPerfil}";

                using(FileStream fs = System.IO.File.Create(fileName))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
            }
            _clienteRepositorio.Add(clienteVM);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var result = _clienteRepositorio.GetById(id.Value);
            if(result == null)
            {
                return NotFound();
            }
            
            return View(result);
        }
    
        public IActionResult Edit(int? id)
        {

            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var result = _clienteRepositorio.GetById(id.Value);
            if (result == null)
            {
                return NotFound();
            }

            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(ClienteVM clienteVM)
        {
            
            if(!ModelState.IsValid)
            {
                return View();
            }
            _clienteRepositorio.Update(clienteVM);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _clienteRepositorio.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
