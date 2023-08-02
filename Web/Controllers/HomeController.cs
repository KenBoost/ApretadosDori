using AplicationCore.Services;
using Infraestructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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
                //if (TempData["mensaje"] != null)
                    //ViewBag.NotificationMessage = TempData["mensaje"].ToString();
            }
            catch (Exception e)
            {
               // Infraestructure.Util.Log.Error(e, MethodBase.GetCurrentMethod());
            }

            return View(lista);
        }

    }
}