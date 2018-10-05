using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Models;

namespace ExamManagementSystem.Controllers
{
    public class AccountController : Controller
    {
      
        UserAccountManager _userAccountManager=new UserAccountManager();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserAcount userAcount)
        {
            if (ModelState.IsValid)
            {
                var Register = _userAccountManager.Add(userAcount);
                if (Register !=null)
                {
                    ViewBag.msc = userAcount.FirstName + " " + userAcount.LastName + " " + "Successfully Registered";
                    ModelState.Clear();
                    //return RedirectToAction("Index");
                }
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Login(UserAcount userAcount)
        
{
            var usr = _userAccountManager.Login(userAcount);
            if (usr !=null)
            {
                Session["UserId"] = usr.UserId.ToString();
                Session[" UserName"] = usr.UserName.ToString();
                ViewBag.message = userAcount.FirstName + " " + userAcount.LastName + " " + "Successfully login";
                ModelState.Clear();

                //return RedirectToAction("LoggedIn");
               
            }
            else
            {
                ModelState.AddModelError("","userName or Password is wrong");
            }
            return View();
        }


        public ActionResult LoggedIn()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}
