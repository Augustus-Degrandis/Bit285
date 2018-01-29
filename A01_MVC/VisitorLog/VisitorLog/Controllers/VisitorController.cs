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