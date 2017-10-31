using MVC_SecondMethod.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_SecondMethod.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        Student_RegisterationContext context = new Student_RegisterationContext();

        public ActionResult Index()
        {
            List<StudentDetail> objList = context.StudentDetails.ToList();
            return View(objList);
        }

        //
        // GET: /Admin/Details/5

        public ActionResult Details(int id)
        {
            StudentDetail Obj = context.StudentDetails.Where(e => e.studentId == id).SingleOrDefault();
            return View(Obj);
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
        public ActionResult Create(StudentDetail collection)
        {
            try
            {
                // TODO: Add insert logic here
                context.StudentDetails.Add(collection);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Admin/Edit/5
 
        public ActionResult Edit(int id)
        {
            StudentDetail Obj = context.StudentDetails.Where(e => e.studentId == id).SingleOrDefault();
            return View(Obj);
        }

        //
        // POST: /Admin/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, StudentDetail collection)
        {
            try
            {
                // TODO: Add update logic here
                StudentDetail Obj = context.StudentDetails.Where(e => e.studentId == id).SingleOrDefault();
                Obj.name = collection.name;
                Obj.eMail = collection.eMail;
                Obj.password = collection.password;
                Obj.course = collection.course;
                Obj.district = collection.district;
                Obj.gender = collection.gender;

                context.Entry(Obj).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/Delete/5
 
        public ActionResult Delete(int id)
        {
            StudentDetail Obj = context.StudentDetails.Where(e => e.studentId==id).SingleOrDefault();
            return View(Obj);
        }

        //
        // POST: /Admin/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, StudentDetail collection)
        {
            try
            {
                // TODO: Add delete logic here
                StudentDetail Obj = context.StudentDetails.Find(id);
                context.StudentDetails.Remove(Obj);
                context.SaveChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
