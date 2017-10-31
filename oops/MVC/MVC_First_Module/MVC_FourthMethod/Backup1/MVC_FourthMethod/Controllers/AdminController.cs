using DAL.Models;
using MVC_FourthMethod.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_FourthMethod.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        Student_RegisterationContext db = new Student_RegisterationContext();

        public ActionResult Index()
        {
            var al = this.db.StudentDetails.ToList();
            List<ent_Registration> return_list = new List<ent_Registration>();
            foreach (var obj in al)
            {
                return_list.Add(new ent_Registration
                {
                    studentId = obj.studentId,
                    name = obj.name,
                    eMail = obj.eMail,
                    password = obj.password,
                    course = obj.course,
                    district = obj.district,
                    gender = obj.gender
                });
            }
            return this.View(return_list);

        }

        //
        // GET: /Admin/Details/5

        public ActionResult Details(int id)
        {
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

        [HttpPost]
        public ActionResult Create(ent_Registration collection)
        {
            try
            {
                // TODO: Add insert logic here

                //var errors = ModelState.Values.SelectMany(v => v.Errors);

                if (ModelState.IsValid)
                {
                    StudentDetail tbl_obj = new StudentDetail();
                    tbl_obj.studentId = collection.studentId;
                    tbl_obj.name = collection.name;
                    tbl_obj.eMail = collection.eMail;
                    tbl_obj.password = collection.password;
                    tbl_obj.course = collection.course;
                    tbl_obj.district = collection.district;
                    tbl_obj.gender = collection.gender;

                    // Insert to the data base
                    this.db.StudentDetails.Add(tbl_obj);
                    this.db.SaveChanges();
                    return this.RedirectToAction("Index");
                }
                return View(collection);
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
            ent_Registration return_obj = new ent_Registration();
            StudentDetail tbl_obj = db.StudentDetails.Find(id);
            return_obj.studentId = tbl_obj.studentId;
            return_obj.name = tbl_obj.name;
            return_obj.eMail = tbl_obj.eMail;
            return_obj.password = tbl_obj.password;
            return_obj.course = tbl_obj.course;
            return_obj.district = tbl_obj.district;
            return_obj.gender = tbl_obj.gender;
            return View(return_obj);
        }

        //
        // POST: /Admin/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, ent_Registration collection)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    StudentDetail tbl_obj = new StudentDetail();
                    tbl_obj.studentId = id;
                    tbl_obj.name = collection.name;
                    tbl_obj.eMail = collection.eMail;
                    tbl_obj.password = collection.password;
                    tbl_obj.course = collection.course;
                    tbl_obj.district = collection.district;
                    tbl_obj.gender = collection.gender;

                    this.db.Entry(tbl_obj).State = EntityState.Modified;
                    this.db.SaveChanges();

                    return RedirectToAction("Index");
                }

                return View(collection);
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
            ent_Registration return_obj = new ent_Registration();
            StudentDetail tbl_obj = db.StudentDetails.Find(id);
            return_obj.studentId = tbl_obj.studentId;
            return_obj.name = tbl_obj.name;
            return_obj.eMail = tbl_obj.eMail;
            return_obj.password = tbl_obj.password;
            return_obj.course = tbl_obj.course;
            return_obj.district = tbl_obj.district;
            return_obj.gender = tbl_obj.gender;

            if (tbl_obj == null)
            {
                return this.HttpNotFound();
            }

            return View(return_obj);
        }

        //
        // POST: /Admin/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                StudentDetail user = this.db.StudentDetails.Find(id);
                this.db.StudentDetails.Remove(user);
                this.db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
