using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DB55.ViewModel;
using DB55.Models;
using System.Data.Entity.Validation;

namespace DB55.Controllers
{
    public class DiseaseController : Controller
    {
        // GET: Disease
        public ActionResult Index()
        {
            DB55Entities db = new DB55Entities();
            List<DiseasesModel> viewlist = new List<DiseasesModel>();
            DiseasesModel obj = new DiseasesModel();
            List<Disease> list1 = db.Diseases.ToList();
            for (int i = 0; i < list1.Count; i++)
            {
                Disease d = list1.ElementAt(i);
                obj.Name = d.Name;
                obj.CategoryId = d.CategoryId;
                obj.PredictionID = d.PredictionID;
                viewlist.Add(obj);
            }
            return View(viewlist);

        }
        [HttpGet]
        public ActionResult AddDisease()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDisease(DiseasesModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    DB55Entities db = new DB55Entities();
                    Disease d1 = new Disease();
                    d1.Name = model.Name;
                    d1.PredictionID = model.PredictionID;
                    d1.DoctorId = 1;
                    d1.CategoryId = 1;
                    db.Diseases.Add(d1);
                    db.SaveChanges();

                    db.SaveChanges();

                    return RedirectToAction("Index", "Disease");
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
            }
            return View();

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
        public ActionResult AddReason(ReasonModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    DB55Entities db = new DB55Entities();
                    Reason r1 = new Reason();
                    r1.Name = model.Name;
                    r1.DoctorId = 1;
                    db.Reasons.Add(r1);
                    db.SaveChanges();

                    db.SaveChanges();

                    return RedirectToAction("Index", "Disease");
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
            }
            return View();

        }

        public ActionResult AddSymptom(SymptomsModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    DB55Entities db = new DB55Entities();
                    Symptom s1 = new Symptom();
                    s1.Name = model.Name;
                    s1.DoctorId = 1;
                    db.Symptoms.Add(s1);
                    db.SaveChanges();

                    db.SaveChanges();

                    return RedirectToAction("Index", "Disease");
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
            }
            return View();

        }

        public ActionResult AddMedicine(MedicineModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    DB55Entities db = new DB55Entities();
                    Medicine m1 = new Medicine();
                    m1.Name = model.Name;
                    m1.DoctorId = 1;
                    db.Medicines.Add(m1);
                    db.SaveChanges();

                    db.SaveChanges();

                    return RedirectToAction("Index", "Disease");
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
            }
            return View();

        }
    }
}
