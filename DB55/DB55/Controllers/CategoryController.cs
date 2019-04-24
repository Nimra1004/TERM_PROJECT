using DB55.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DB55.Controllers
{
    public class CategoryController : Controller
    {
        DB55Entities db = new DB55Entities();
        // GET: Category
        public ActionResult Index()
        {
            
            List<Category> list1 = db.Categories.ToList();
            List<CategoryViewModel> viewList = new List<CategoryViewModel>();
            foreach (Category s in list1)
            {
                CategoryViewModel obj = new CategoryViewModel();
                obj.Id = s.Id;
                obj.Name = s.Name;
                viewList.Add(obj);

            }
            return View(viewList);

           
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(CategoryViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                DB55Entities db = new DB55Entities();
                //var userdbmodel = db.AspNetUsers.Where(a => a.Email.Equals(model.Email)).FirstOrDefault();
                Category c = new Category();
                c.Name = model.Name;
                db.Categories.Add(c);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        //GET: Select
        public ActionResult Select(int id)
        {
            return View();
        }

        //hhtppost: Select
        [HttpPost]
        public ActionResult Select(int id, FormCollection collection)
        {
            return View();
        }


        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Category/Edit/5
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

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Category/Delete/5
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
