//Augustus DeGrandis
//Bit 285 Assignment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VisitorLog.Models;

namespace VisitorLog.Controllers
{
    public class VisitorController : Controller
    {
        private MyDbContext db = new MyDbContext();
        
        [HttpPost]
        public ActionResult Login(Visitor visitor)
        {
            //Updates and saves the database with user information IP adress and Time of form submission
            visitor.LoginTime = DateTime.Now;
            visitor.IpAdress = Request.UserHostAddress;
            db.Visitors.Add(visitor);
            db.SaveChanges();
            return View("Index", db.Visitors);
        }
        public ActionResult Login()
        {
            return View();
        }
        // GET: Visitor
        public ActionResult Index()
        {
            return View(db.Visitors);
        }
    }
}