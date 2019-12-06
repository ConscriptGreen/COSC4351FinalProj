using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using COSC4351.AuthData;
using COSC4351.DAL;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace COSC4351.Controllers
{
    public class HomeController : Controller
    {
        private CSContext db = new CSContext();

        // Home page on start and that the home button routes to
        public ActionResult Index(int? id)
        {
            if (id == 1)
            {
                if (ApplicationSession.Username != "")
                {
                    ApplicationSession.Username = "";
                    ApplicationSession.AccessLevel = "";
                }
            }

            ViewBag.AccessLevel = ApplicationSession.AccessLevel;
            return View();
        }

        [AuthAttribute]
        public ActionResult EmployeeProfile()
        {

            if (ApplicationSession.AccessLevel == "Manager")
            {
                if (ApplicationSession.Username == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                ELogin login = db.ELogin.Single(x => x.LoginEmail == ApplicationSession.Username);
                Employee companyEmployee = db.Employee.Find(login.EmployeeID);

                if (companyEmployee == null)
                {
                    return HttpNotFound();
                }

                ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "DName", companyEmployee.DepartmentID);
                return View(companyEmployee);
            }
            else
                return Redirect(ApplicationSession.RedirectToHomeURL);
        }

        [AuthAttribute]
        public ActionResult AdminHub()
        {
            if (ApplicationSession.AccessLevel == "DManager")
                return View();
            else
                return Redirect(ApplicationSession.RedirectToHomeURL);
        }
    }
}
