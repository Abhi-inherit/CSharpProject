using DAL.Models;
using MVC_Fourth_2nd_Method.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Fourth_2nd_Method.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        FirstMCV_PartialViewContext db = new FirstMCV_PartialViewContext();

        public ActionResult Index()
        {
            var albums = this.db.tbl_People.ToList();
            List<ent_Registration> return_list = new List<ent_Registration>();
            foreach (var obj in albums)
            {
                return_list.Add(new ent_Registration
                {
                    Id = obj.Id,
                    Name = obj.Name,
                    DateOfBirth = Convert.ToDateTime(obj.DateOfBirth),
                    Address = obj.Address,
                    Phone = obj.Phone,
                    PlaceID = Convert.ToInt32(obj.Place),
                    PlaceName = obj.tbl_Place.PlaceName,
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
