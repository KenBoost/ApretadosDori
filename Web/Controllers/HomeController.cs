using AplicationCore.Services;
using Infraestructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<Apretados> lista = null;
            try
            {
                IServiceApretado SApretado = new ServiceApretado();
                lista = SApretado.GetApretados();
                ViewBag.lista = lista.ToList();
            }
            catch (Exception e)
            {
               Infraestructure.Util.Log.Error(e, MethodBase.GetCurrentMethod());
            }

            return View(lista);
        }

        public ActionResult FormularioLogin()
        {
            return View();
        }


        public ActionResult Login(Usuario usuario)
        {
            IServiceUsuario _ServiceUsuario = new ServiceUsuario();
            Usuario oUsuario = null;


            ModelState.Remove("estado");
            ModelState.Remove("telefono");
            ModelState.Remove("nombre");
            ModelState.Remove("apellidos");
            ModelState.Remove("rol_id");
            try
            {
                if (ModelState.IsValid)
                {
                    oUsuario = _ServiceUsuario.LogIn(usuario.ID, usuario.clave);
                    if (oUsuario != null)
                    {
                            Session["User"] = oUsuario;
                            Infraestructure.Util.Log.Info("\n");
                            string msj = "Nuevo inicio de sesión por: ";
                            Infraestructure.Util.Log.Info(msj + usuario.clave + " Correo:" + usuario.correo_electronico);
                            return RedirectToAction("IndexAdmin");
                        
                        Session["User"] = oUsuario;
                        return RedirectToAction("Index");
                    }
                }
                return View("Loguearse");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Default", "Error");
            }
        }
    }
}