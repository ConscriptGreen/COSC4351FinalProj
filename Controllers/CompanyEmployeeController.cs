using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using COSC4351;
using COSC4351.AuthData;
using COSC4351.DAL;
using COSC4351.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace COSC4351.Controllers
{
    [AuthAttribute]
    public class CompanyEmployeeController : Controller
    {
        private CSContext db = new CSContext();

        // GET: companyEmployee
        public ActionResult Index()
        {
            if (ApplicationSession.AccessLevel == "Manager")
            {
                var companyEmployee = db.Employee.Include(p => p.Department);
                return View(companyEmployee.ToList());
            }
            else
            {
                return Redirect(ApplicationSession.RedirectToHomeURL);
            }
        }

        // GET: companyEmployee/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee companyEmployee = db.Employee.Find(id);
            if (companyEmployee == null)
            {
                return HttpNotFound();
            }
            return View(companyEmployee);
        }

        // GET: companyEmployee/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "DName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeVM employee)
        {
            if (ModelState.IsValid)
            {

                //check database for existing username
                if (db.ELogin.Any(x => x.LoginEmail == employee.LoginEmail))
                {
                    ModelState.AddModelError(string.Empty, "Email already exists");
                    return RedirectToAction("Index");
                }
                else
                {
                    var companyEmployee = new Employee();
                    companyEmployee.FirstName = employee.FirstName;
                    companyEmployee.LastName = employee.LastName;
                    companyEmployee.MiddleName = employee.MiddleName;
                    companyEmployee.StreetAddress = employee.StreetAddress;
                    companyEmployee.State = employee.State;
                    companyEmployee.City = employee.City;
                    companyEmployee.ZipCode = employee.ZipCode;
                    companyEmployee.DoB = employee.DoB;
                    companyEmployee.Sex = employee.Sex;
                    companyEmployee.JobTitle = employee.JobTitle;
                    companyEmployee.DepartmentID = employee.DepartmentID;

                    var login = new ELogin();
                    login.Employee = companyEmployee;
                    login.LoginEmail = employee.LoginEmail;
                    login.Password = employee.Password;

                    db.companyEmployee.Add(companyEmployee);
                    db.EmployeeLogins.Add(login);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "DName", employee.DepartmentID);
            return View(employee);
        }

        // GET: companyEmployee/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee companyEmployee = db.Employee.Find(id);
            if (companyEmployee == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "DName", companyEmployee.DepartmentID);
            return View(companyEmployee);
        }

        // POST: companyEmployee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeID,FirstName,MiddleName,LastName,StreetAddress,State,City,ZipCode,PhoneNumber,DateOfBirth,Sex,JobTitle,DepartmentID")] Employee companyEmployee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(companyEmployee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "DName", companyEmployee.DepartmentID);
            return View(companyEmployee);
        }

        // GET: companyEmployee/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee companyEmployee = db.Employee.Find(id);
            if (companyEmployee == null)
            {
                return HttpNotFound();
            }
            return View(companyEmployee);
        }

        // POST: companyEmployee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Employee companyEmployee = db.Employee.Find(id);
            db.Employee.Remove(companyEmployee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
