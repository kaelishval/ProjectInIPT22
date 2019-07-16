using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ipt2project.Models;

namespace ipt2project.Controllers
{
    public class ProductController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Product
        public ActionResult ViewProduct()
        {
            return View(db.Product.ToList());
        }
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Products prod)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (DataContext db = new DataContext())
                    {
                        db.Product.Add(prod);
                        db.SaveChanges();
                    }
                    ModelState.Clear();
                }
                return RedirectToAction("ViewProduct");
            }
            catch
            {
                return RedirectToAction("ViewProduct");
            }
        }
        public ActionResult EditProduct(int id)
        {
            using (DataContext db = new DataContext())
            {
                return View(db.Product.Where(x => x.product_id == id).FirstOrDefault());
            }
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult EditProduct(Products prod)
        {
            try
            {
                using (DataContext db = new DataContext())
                {
                    db.Entry(prod).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("ViewProduct");
            }
            catch
            {
                return RedirectToAction("ViewProduct");
            }
        }

        public ActionResult DeleteProduct(int id)
        {
            using (DataContext db = new DataContext())
            {
                return View(db.Product.Where(x => x.product_id== id).FirstOrDefault());
            }
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult DeleteProduct(int id, Products prod)
        {
            try
            {
                using (DataContext db = new DataContext())
                {
                    prod = db.Product.Where(x => x.product_id == id).FirstOrDefault();
                    db.Product.Remove(prod);
                    db.SaveChanges();
                }
                return RedirectToAction("ViewProduct");
            }
            catch
            {
                return View();
            }
        }
    }
}