﻿using System.Web.Mvc;

namespace AirSur_Web.Controllers
{
    public class SoldadoController : Controller
    {
        // GET: Soldado
        public ActionResult Index()
        {
            return View();
        }

        // GET: Soldado/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Soldado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Soldado/Create
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

        // GET: Soldado/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Soldado/Edit/5
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

        // GET: Soldado/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Soldado/Delete/5
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
