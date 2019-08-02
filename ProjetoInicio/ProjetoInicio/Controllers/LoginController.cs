using ProjetoInicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoInicio.Controllers
{
    public class LoginController : Controller
    {

        Contexto db = new Contexto();
        // GET: Login
        public ActionResult Index()
        {
            if (TempData["ViewData"] != null) 
            {
                ViewData = (ViewDataDictionary)TempData["ViewData"];
            }
            return View();
        }

        public ActionResult Autenticar(string login, string senha)
        {

            try
            {
                var usuario = db.Usuarios.FirstOrDefault(p => p.Login == login && p.Senha == senha);

                if (usuario.Admim == true)
                {
                    Session["admLogado"] = usuario;
                    return RedirectToAction("Index", "Usuarios");
                }
                else
                {
                    Session["usuarioLogado"] = usuario;
                    return RedirectToAction("Login", "Home");
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Usuario ou senha invalidos");
                TempData["ViewData"] = ViewData;
                return RedirectToAction("Index");
            }


        }
        public ActionResult Sair()
        {
            Session["admLogado"] = null;
            Session["usuarioLogado"] = null;

            return RedirectToAction("Index", "Home");
        }
    }
}