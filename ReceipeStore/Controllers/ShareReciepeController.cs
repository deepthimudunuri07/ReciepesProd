using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReceipeStore.Controllers
{
    public class ShareReciepeController : Controller
    {
        // GET: ShareReciepe
        public ActionResult ShareReciepe()
        {
            return View();
        }

        // GET: ShareReciepe/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShareReciepe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShareReciepe/Create
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

        // GET: ShareReciepe/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShareReciepe/Edit/5
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

        // GET: ShareReciepe/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShareReciepe/Delete/5
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
