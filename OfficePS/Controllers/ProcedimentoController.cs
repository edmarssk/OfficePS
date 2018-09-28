using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OfficePS.Models;

namespace OfficePS.Controllers
{
    public class ProcedimentoController : Controller
    {
        private readonly IProcedimentosRepositorio _procedimentosRepositorio;

        public ProcedimentoController(IProcedimentosRepositorio procedimentosRepositorio)
        {
            _procedimentosRepositorio = procedimentosRepositorio;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var procedimentos = _procedimentosRepositorio.GetAll();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Procedimentos procedimento)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            _procedimentosRepositorio.Create(procedimento);
            return RedirectToAction("Index");

        }
    }
}