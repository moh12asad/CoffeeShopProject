using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CoffeeShopProject.Data;
using CoffeeShopProject.UserDal;
using CoffeeShopProject.Models;

namespace CoffeeShopProject.Controllers
{
    public class UsersController : Controller
    {
        private CoffeeShopProjectContext db = new CoffeeShopProjectContext();

        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }
        public ActionResult HomePage()
        {
            return View();
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Age,Vip,UserType,pin")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Age,Vip,UserType,credit,pin")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Login(Models.User u)
        {
            User activeuser = db.Users.Where(x => x.FirstName==u.FirstName && x.LastName==u.LastName && x.pin==u.pin).FirstOrDefault();
            if (activeuser == null)
            {
                ViewBag.message ="One or more details are invaild";
                return View("Login");
            }
            if (u.FirstName=="admin")
                     return View("Admin");

            if (u.LastName  == "Barista")
                return RedirectToAction("BaristaOrders", "Products",u);

            return RedirectToAction("Menu","Products",activeuser);
        }
        public ActionResult Register1()
        {
            return View("Register", "Users");
        }

        public ActionResult Login1()
        {
            return View("Login","Users");
        }

        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login");
            }

            return View(user);
        }

    }
}

