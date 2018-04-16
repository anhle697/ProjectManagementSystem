using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectManagementSystem.Models;

namespace ProjectManagementSystem.Controllers
{
    public class User_LoginController : Controller
    {
        private ProjectManagementSystemEntities db = new ProjectManagementSystemEntities();

        // Go to Login Page
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost] public ActionResult Authorize(ProjectManagementSystem.Models.User_Login user_Login)
        {
            using (ProjectManagementSystemEntities db = new ProjectManagementSystemEntities())
            {
                var userDetails = db.User_Login.Where(x => x.Username == user_Login.Username && x.Password == user_Login.Password).FirstOrDefault();
                if (userDetails == null)
                {
                    user_Login.LoginErrorMessage = "Wrong username or password.";
                    return View("Index", user_Login);
                }
                else
                {
                    Session["userID"] = userDetails.UserID;
                    Session["userName"] = userDetails.Username;
                    return RedirectToAction("Index", "Home");
                }
            }
        }

        public ActionResult LogOut()
        {
            int userId = (int)Session["userID"];
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
       
}
