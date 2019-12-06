using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COSC4351;
using COSC4351.ViewModels;

namespace COSC4351.Controllers
{
    public class EmployeeAccountController : Controller
    {
        // GET: EmployeeAccount
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(EmployeeLoginVM userAuthInfo)
        {
            if (ModelState.IsValid)
            {

                //need to get the Employee ID from the login table
                //Use that ID to identify if that employee is a manager (Admin)
                var context = new COSC4351Context();
                if (context.ELogin.Any(x => x.LoginEmail == userAuthInfo.Username && x.Password == userAuthInfo.Password) == true)
                {
                    var EmployeeLogin = context.ELogin.Single(x => x.LoginEmail == userAuthInfo.Username && x.Password == userAuthInfo.Password);
                    if (EmployeeLogin != null && context.DManager.any(x => x.DepartmentID = 1))
                    {
                        ApplicationSession.AccessLevel = "Admin";
                        ApplicationSession.Username = userAuthInfo.Username;
                        return Redirect("/Home/AdminHub");
                    }
                    else if (EmployeeLogin != null && context.DManager.any(x => x.DepartmentID = 2))
                    {
                        ApplicationSession.AccessLevel = "FManager";
                        ApplicationSession.Username = userAuthInfo.Username;
                        return Redirect("/Home/FManager");
                    }
                    else if (EmployeeLogin != null && context.DManager.any(x => x.DepartmentID = 3))
                    {
                        ApplicationSession.AccessLevel = "SManager";
                        ApplicationSession.Username = userAuthInfo.Username;
                        return Redirect("/Home/SManager");
                    }
                    else if (EmployeeLogin != null && context.DManager.any(x => x.DepartmentID = 4))
                    {
                        ApplicationSession.AccessLevel = "HRManager";
                        ApplicationSession.Username = userAuthInfo.Username;
                        return Redirect("/Home/HRManager");
                    }
                    else if (EmployeeLogin != null && context.DManager.any(x => x.DepartmentID = 5))
                    {
                        ApplicationSession.AccessLevel = "EManager";
                        ApplicationSession.Username = userAuthInfo.Username;
                        return Redirect("/Home/EManager");
                    }
                    else if (EmployeeLogin != null && context.DManager.any(x => x.DepartmentID = 6))
                    {
                        ApplicationSession.AccessLevel = "SuperAdmin";
                        ApplicationSession.Username = userAuthInfo.Username;
                        return Redirect("/Home/SuperAdmin");
                    }
                    else
                    {
                        // Display error
                        ModelState.AddModelError(string.Empty, "Invalid Username or Password");
                        return View(userAuthInfo);

                    }
                }
                else
                {
                    // Display error
                    ModelState.AddModelError(string.Empty, "Invalid Username or Password");
                    return View(userAuthInfo);
                }
            }
            else
            {
                return View();
            }

        }
    }
}