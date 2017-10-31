using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExercise.Models;

namespace MVCExercise.Controllers
{ 
    public class AdminController : Controller
    {
        private Student_RegisterationContext db = new Student_RegisterationContext();

        //
        // GET: /Admin/

        public ViewResult Index()
        {
            return View(db.StudentDetails.ToList());
        }

        //
        // GET: /Admin/Details/5

        public ViewResult Details(int id)
        {
            StudentDetail studentdetail = db.StudentDetails.Find(id);
            return View(studentdetail);
        }

        //
        // GET: /Admin/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Admin/Create

        [HttpPost]
        public ActionResult Create(StudentDetail studentdetail)
        {
            if (ModelState.IsValid)
            {
                db.StudentDetails.Add(studentdetail);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(studentdetail);
        }
        
        //
        // GET: /Admin/Edit/5
 
        public ActionResult Edit(int id)
        {
            StudentDetail studentdetail = db.StudentDetails.Find(id);
            return View(studentdetail);
        }

        //
        // POST: /Admin/Edit/5

        [HttpPost]
        public ActionResult Edit(StudentDetail studentdetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentdetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentdetail);
        }

        //
        // GET: /Admin/Delete/5
 
        public ActionResult Delete(int id)
        {
            StudentDetail studentdetail = db.StudentDetails.Find(id);
            return View(studentdetail);
        }

        //
        // POST: /Admin/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            StudentDetail studentdetail = db.StudentDetails.Find(id);
            db.StudentDetails.Remove(studentdetail);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}