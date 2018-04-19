using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectManagementSystem.Models;

namespace ProjectManagementSystem.Controllers
{
    public class User_loginController : Controller
    {
        // GET: User_login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorize(ProjectManagementSystem.Models.User_login user_Login)
        {
            using (ProjectManagementSystemEntities db = new ProjectManagementSystemEntities())
            {
                var userDetails = db.User_login.Where(x => x.Username == user_Login.Username && x.Password == user_Login.Password).FirstOrDefault();
                if (userDetails == null)
                {
                    user_Login.LoginErrorMessage = "Wrong username or password.";
                    return View("Index", user_Login);
                }
                else
                {
                    Session["userID"] = userDetails.Employee_ID;
                    Session["userName"] = userDetails.Username;
                    return RedirectToAction("Index", "Home");
                }
            }
        }

        public ActionResult LogOut()
        {
            int userId = (int)Session["userID"];
            Session.Abandon();
            return RedirectToAction("Index", "User_login");
        }
    }
}
