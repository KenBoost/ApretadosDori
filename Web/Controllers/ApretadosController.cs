using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class ApretadosController : Controller
    {
        // GET: Apretados
        public ActionResult Index()
        {
            return View();
        }

        // GET: Apretados/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Apretados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Apretados/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Apretados/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Apretados/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Apretados/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Apretados/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
