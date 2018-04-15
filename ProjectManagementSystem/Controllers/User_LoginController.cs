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
    }
       
}
