using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OfficePS.ViewModels;

namespace OfficePS.Controllers
{
    public class AcessoController : Controller
    {

        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AcessoController(SignInManager<IdentityUser> signInManager,UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UsuarioAcessoVM usuarioAcessoVM)
        {
            if (!ModelState.IsValid)
            {
                return View(usuarioAcessoVM);
            }

            var user = await _userManager.FindByNameAsync(usuarioAcessoVM.NomeUsuario);

            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, usuarioAcessoVM.Senha, false, false);

                if (result.Succeeded)
                    return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Usuário/Senha inválidos");

            return View(usuarioAcessoVM);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(UsuarioAcessoVM usuarioAcessoVM)
        {
            if(!ModelState.IsValid)
            {
                return View(usuarioAcessoVM);
            }

            var usuario = new IdentityUser() { UserName = usuarioAcessoVM.NomeUsuario };

            var result = await _userManager.CreateAsync(usuario, usuarioAcessoVM.Senha);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", result.Errors.ToArray().First().Description);
            return View(usuarioAcessoVM);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}