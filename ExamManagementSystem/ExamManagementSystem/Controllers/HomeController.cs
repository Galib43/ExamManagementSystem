using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Models;

namespace ExamManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private ExamManagementDbContext db = new ExamManagementDbContext();

        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
      
    }
}
