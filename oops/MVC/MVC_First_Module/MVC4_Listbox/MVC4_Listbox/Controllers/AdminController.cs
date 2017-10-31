using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Models;
using MVC4_Listbox.Models;

namespace MVC4_Listbox.Controllers
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
            ent_Registration return_obj = new ent_Registration();
            tbl_People tbl_obj = db.tbl_People.Find(id);
            return_obj.Id = tbl_obj.Id;
            return_obj.Name = tbl_obj.Name;
            return_obj.DateOfBirth = Convert.ToDateTime(tbl_obj.DateOfBirth);
            return_obj.Address = tbl_obj.Address;
            return_obj.Phone = tbl_obj.Phone;
            return_obj.PlaceID = Convert.ToInt32(tbl_obj.Place);
            return_obj.PlaceName = tbl_obj.tbl_Place.PlaceName;
            this.ViewBag.PlaceID = new SelectList(this.db.tbl_Place, "Id", "PlaceName", tbl_obj.Place);
            return this.View(return_obj);
        }

        //
        // GET: /Admin/Create

        public ActionResult Create()
        {
            this.ViewBag.PlaceID = new SelectList(this.db.tbl_Place, "Id", "PlaceName");
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
                if (ModelState.IsValid)
                {
                    tbl_People tbl_obj = new tbl_People();

                    tbl_obj.Name = collection.Name;
                    tbl_obj.DateOfBirth = collection.DateOfBirth.ToShortDateString();
                    tbl_obj.Address = collection.Address;
                    tbl_obj.Phone = collection.Phone;
                    tbl_obj.Place = collection.PlaceID;
                    this.db.tbl_People.Add(tbl_obj);
                    this.db.SaveChanges();
                    return this.RedirectToAction("Index");
                }
                this.ViewBag.PlaceID = new SelectList(this.db.tbl_Place, "Id", "PlaceName", collection.PlaceID);
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
            tbl_People tbl_obj = db.tbl_People.Find(id);
            return_obj.Id = tbl_obj.Id;
            return_obj.Name = tbl_obj.Name;
            return_obj.DateOfBirth = Convert.ToDateTime(tbl_obj.DateOfBirth);
            return_obj.Address = tbl_obj.Address;
            return_obj.Phone = tbl_obj.Phone;
            return_obj.PlaceID = Convert.ToInt32(tbl_obj.Place);
            return_obj.PlaceName = tbl_obj.tbl_Place.PlaceName;
            this.ViewBag.PlaceID = new SelectList(this.db.tbl_Place, "Id", "PlaceName", tbl_obj.Place);
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
                    tbl_People tbl_obj = new tbl_People();
                    tbl_obj.Id = collection.Id;
                    tbl_obj.Name = collection.Name;
                    tbl_obj.DateOfBirth = collection.DateOfBirth.ToShortDateString();
                    tbl_obj.Address = collection.Address;
                    tbl_obj.Phone = collection.Phone;
                    tbl_obj.Place = collection.PlaceID;

                    // Update to the database
                    this.db.Entry(tbl_obj).State = EntityState.Modified;
                    this.db.SaveChanges();

                    return this.RedirectToAction("Index");
                }
                this.ViewBag.PlaceID = new SelectList(this.db.tbl_Place, "Id", "PlaceName", collection.PlaceID);
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
            tbl_People tbl_obj = db.tbl_People.Find(id);
            return_obj.Id = tbl_obj.Id;
            return_obj.Name = tbl_obj.Name;
            return_obj.DateOfBirth = Convert.ToDateTime(tbl_obj.DateOfBirth);
            return_obj.Address = tbl_obj.Address;
            return_obj.Phone = tbl_obj.Phone;
            return_obj.PlaceID = Convert.ToInt32(tbl_obj.Place);
            return_obj.PlaceName = tbl_obj.tbl_Place.PlaceName;

            this.ViewBag.PlaceID = new SelectList(this.db.tbl_Place, "Id", "PlaceName", tbl_obj.Place);

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
                tbl_People user = this.db.tbl_People.Find(id);
                this.db.tbl_People.Remove(user);
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
