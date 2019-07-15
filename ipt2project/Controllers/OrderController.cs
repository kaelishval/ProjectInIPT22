using ipt2project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ipt2project.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewAll()
        {
            return View(GetAllOrder());
        }
        IEnumerable<Order> GetAllOrder()
        {
            using (DataContext db = new DataContext())
            {
                return db.Orders.ToList<Order>(); 
            }
        }
        public ActionResult AddorEdit(int id = 0)
        {
            Order ord = new Order();
            return View(ord);
        }
        [HttpPost]
        public ActionResult AddorEdit(Order ord)
        {
            try
            {
                using (DataContext db = new DataContext())
                {
                    db.Orders.Add(ord);
                    db.SaveChanges();
                }
                return Json(new { success = true, html = GlobalClass.RenderRazorViewToString(this, "ViewAll", GetAllOrder()), message = "Submitted Successfully "}, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message}, JsonRequestBehavior.AllowGet);
                throw;
            }
        }
        public ActionResult Delete(int id)
        {
            try
            {
                using(DataContext db = new DataContext())
                {
                    Order ord = db.Orders.Where(x => x.Id == id).FirstOrDefault<Order>();
                    db.Orders.Remove(ord);
                    db.SaveChanges();
                }
                return Json(new { success = true, html = GlobalClass.RenderRazorViewToString(this, "ViewAll", GetAllOrder()), message = "Deleted Successfully " }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
                
            }

        }


        public ActionResult Delivered(int id)
        {
            try
            {
                using (DataContext db = new DataContext())
                {
                    Order ord = db.Orders.Find(id);
                    History hist = db.Historys.Find(id);
                    History.id=Order.id;
                    db.SaveChanges();

                   


                }
                return Json(new { success = true, html = GlobalClass.RenderRazorViewToString(this, "ViewAll", GetAllOrder()), message = "Delivered Successfully " }, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }

        }

    }  
}