using DB55.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DB55.Controllers
{
    public class DiseaseController : Controller
    {
        DB55Entities db = new DB55Entities();
        // GET: Disease
        public ActionResult Index()
        {
            List<Disease> list1 = db.Diseases.ToList();
            List<DiseaseViewModel> viewList = new List<DiseaseViewModel>();
            foreach (Disease s in list1)
            {
                DiseaseViewModel obj = new DiseaseViewModel();
                obj.Id = s.Id;
                obj.Name = s.Name;
                //obj.DoctorId = 
                viewList.Add(obj);

            }
            return View(viewList);
        }

        // GET: Disease/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Disease/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Disease/Create
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

        // GET: Disease/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Disease/Edit/5
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

        // GET: Disease/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Disease/Delete/5
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
