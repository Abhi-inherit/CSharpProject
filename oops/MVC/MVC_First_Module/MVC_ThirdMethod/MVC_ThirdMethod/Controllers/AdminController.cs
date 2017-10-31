using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_ThirdMethod.Models;
using System.Data;


namespace MVC_ThirdMethod.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        Student_RegisterationEntities1 db;

        public AdminController()
        {
            db = new Student_RegisterationEntities1();
        }

        public ActionResult Index()
        {
            ViewData.Model = db.StudentDetails.ToList();
            return View();
        }

        //
        // GET: /Admin/Details/5

        public ActionResult Details(int id)
        {
            ViewData.Model = db.StudentDetails.Where(e => e.studentId == id).SingleOrDefault();
            return View();
        }

        //
        // GET: /Admin/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Admin/Create

          [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(FormCollection collection)
        {
            
                var detailsToAdd = new StudentDetail();
                TryUpdateModel(detailsToAdd, new string[] { " studentId", "name", "eMail", "password", "course", "district", "gender" }, collection.ToValueProvider());
                if (String.IsNullOrEmpty(detailsToAdd.name))
                    ModelState.AddModelError("name", "Name is required!");
                if (String.IsNullOrEmpty(detailsToAdd.eMail))
                    ModelState.AddModelError("eMail", "E-Mail is required!");
                if (String.IsNullOrEmpty(detailsToAdd.password))
                    ModelState.AddModelError("password", "Password is required!");
                if (String.IsNullOrEmpty(detailsToAdd.password))
                    ModelState.AddModelError("course", "course is required!");
                if (String.IsNullOrEmpty(detailsToAdd.password))
                    ModelState.AddModelError("district", "District is required!");
                if (String.IsNullOrEmpty(detailsToAdd.password))
                    ModelState.AddModelError("gender", "Gender is required!");
                // TODO: Add insert logic here

                if(ModelState.IsValid)
                {
                    db.StudentDetails.Add(detailsToAdd);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(detailsToAdd);
           
        }
        
        //
        // GET: /Admin/Edit/5
 
        public ActionResult Edit(int id)
        {
            ViewData.Model = db.StudentDetails.Where(e => e.studentId == id).SingleOrDefault();
            return View();
        }

        //
        // POST: /Admin/Edit/5

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                //var Id = collection["studentId"];
                var detailsToUpdate = new StudentDetail();

                TryUpdateModel(detailsToUpdate, new string[] { "studentId", "name", "eMail", "password", "course", "district", "gender" }, collection.ToValueProvider());
                if (String.IsNullOrEmpty(detailsToUpdate.name))
                    ModelState.AddModelError("name", "Name is required!");
                if (String.IsNullOrEmpty(detailsToUpdate.eMail))
                    ModelState.AddModelError("eMail", "E-Mail is required!");
                if (String.IsNullOrEmpty(detailsToUpdate.password))
                    ModelState.AddModelError("password", "Password is required!");
                if (String.IsNullOrEmpty(detailsToUpdate.password))
                    ModelState.AddModelError("course", "course is required!");
                if (String.IsNullOrEmpty(detailsToUpdate.password))
                    ModelState.AddModelError("district", "District is required!");
                if (String.IsNullOrEmpty(detailsToUpdate.password))
                    ModelState.AddModelError("gender", "Gender is required!");

                if (ModelState.IsValid)
                {
                    db.Entry(detailsToUpdate).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(detailsToUpdate);
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
            ViewData.Model = db.StudentDetails.Where(e => e.studentId == id).SingleOrDefault();
            return View();
        }

        //
        // POST: /Admin/Delete/5

         [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var detailsToDelete = db.StudentDetails.First(m => m.studentId == id);
                db.StudentDetails.Remove(detailsToDelete);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
