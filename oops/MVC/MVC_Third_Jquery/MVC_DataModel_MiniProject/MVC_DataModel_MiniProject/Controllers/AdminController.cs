using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using BLL.Manager;
using BLL.Models;

namespace MVC_DataModel_MiniProject.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        UserManager obj_usr = new UserManager();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Slider()
        {
            return PartialView("Slider");
        }

        public ActionResult Home()
        {
            List<entyPlace> objenty = obj_usr.getallPlaces();
            return PartialView("Home", objenty);
        }

        public ActionResult Register()
        {
            return PartialView("Register");
        }

        [HttpGet]
        public JavaScriptResult UserRegister(entyuser obj)
        {

            obj.Updated_date = System.DateTime.Now; ;
            obj.Created_date = System.DateTime.Now;
            string result = obj_usr.saveUser(obj);
            if (result == "Success")
            {
                string js = @"var temp=document.getElementById('msgdiv');temp.innerHTML='Succesfully registered';var tem=document.getElementById('myModal');tem.style.display = 'block';";
                return JavaScript(js);


                //return Json(new {isok=true, message="Success"});
                //string js = @"<div class='alert alert-success agileits' role='alert'><strong>Well done!</strong> alertdiv.</div>";
                //return JavaScript(js);
            }
            else
            {
                string js = @"var temp=document.getElementById('msgdiv');temp.innerHTML='Error';";
                return JavaScript(js);

                //string js = @"<div class='alert alert-success agileits' role='alert'><strong>Well done!</strong> You successfully read this important alert message.</div>";
                //return JavaScript(js);
            }
        
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
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

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
            return View();
        }

        //
        // POST: /Admin/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
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
            return View();
        }

        //
        // POST: /Admin/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
