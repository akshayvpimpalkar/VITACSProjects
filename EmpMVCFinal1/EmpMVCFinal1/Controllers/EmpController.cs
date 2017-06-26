using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmpMVCFinal1.Models;
using System.Data.Entity;

namespace EmpMVCFinal1.Controllers
{
    public class EmpController : Controller
    {
        private Model1Container db = new Model1Container();
        // GET: Emp
        public ActionResult Index()
        {
            var employees = db.Emps.Include(e => e.Dept);
            return View(employees.ToList());
        }

        // GET: Emp/Details/5
        public ActionResult Details(int id)
        {
            Emp employee = db.Emps.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Emp/Create
        public ActionResult Create()
        {
            ViewBag.DeptId = new SelectList(db.Depts, "Id", "Name");
            return View();
        }

        // POST: Emp/Create
        [HttpPost]
        public ActionResult Create(Emp employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Emps.Add(employee);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                ViewBag.DepartmentId = new SelectList(db.Depts, "Id", "Name", employee.DeptId);
                return View(employee);
            }
            catch
            {
                return View();
            }
        }

        // GET: Emp/Edit/5
        public ActionResult Edit(int id)
        {
            Emp employee = db.Emps.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentId = new SelectList(db.Depts, "Id", "Name", employee.DeptId);
            return View(employee);
        }

        // POST: Emp/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Emp employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(employee).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                ViewBag.DepartmentId = new SelectList(db.Depts, "Id", "Name", employee.DeptId);
                return View(employee);
            }
            catch
            {
                return View();
            }
        }

        // GET: Emp/Delete/5
        public ActionResult Delete(int id)
        {
            Emp employee = db.Emps.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Emp/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Emp employee = db.Emps.Find(id);
                db.Emps.Remove(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
