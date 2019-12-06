using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using COSC4351.DAL;

namespace COSC4351.AuthData
{
    public class AuthAttribute : ActionFilterAttribute, IAuthenticationFilter
    {
        private bool _auth;
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            _auth = (filterContext.ActionDescriptor.GetCustomAttributes(typeof(OverrideAuthenticationAttribute), true).Length == 0);
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            var user = filterContext.HttpContext.Session["Username"];
            if (user == null || user.ToString() == "")
            {
                    filterContext.Result = new RedirectResult("~/EmployeeAccount/Login");
            }
        }
    }
}