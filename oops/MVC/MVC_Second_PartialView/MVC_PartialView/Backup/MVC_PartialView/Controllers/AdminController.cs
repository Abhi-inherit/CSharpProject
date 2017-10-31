using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_PartialView.Models;


namespace MVC_PartialView.Controllers
{

    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        FirstMVC_PartialView2Context context = new FirstMVC_PartialView2Context();


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _ListView(string Search = "")
        {
            if (Search != "")
            {
                List<tbl_People> _list = context.tbl_People.Where(e => e.Name.Contains(Search) && e.Status != "D").ToList();
                return PartialView("_ListView", _list);
            }
            else
            {
                List<tbl_People> _list = context.tbl_People.Where(e => e.Status != "D").ToList();
                return PartialView("_ListView", _list);
            }
        }

        [HttpGet]
        public ActionResult _ManageView(int Id = 0) 
        {
            if (Id == 0)
            {
                BindPlace();
                tbl_People regObj = new tbl_People();
                return PartialView("_ManageView", regObj);
            }
            else
            {
                BindPlace(Id);
                tbl_People regObj = context.tbl_People.Where(e => e.Id == Id && e.Status != "D").SingleOrDefault();
                return PartialView("_ManageView", regObj);
            }
        }

        public void BindPlace(int Id = 0)
        {
            List<SelectListItem> DDL_PlacetList = new List<SelectListItem>();
            List<tbl_Place> PlaceList = context.tbl_Place.Where(e => e.Status != "D").ToList();
           // List<tbl_People> PeopleList = context.tbl_People.Where(e => e.Status != "D").ToList();
            if (Id > 0)
            {
                tbl_People PeopleDetails = context.tbl_People.Where(e => e.Status != "D" && e.Id == Id).SingleOrDefault();
                Id = PeopleDetails.Place.Value;

                tbl_Place CurrentPlace = context.tbl_Place.Where(e => e.Status != "D" && e.Id == Id).SingleOrDefault();
                foreach (var Obj in PlaceList)
                {
                    DDL_PlacetList.Add(new SelectListItem
                    {
                        Selected = (Obj.Id == CurrentPlace.Id ? true : false),
                        Text = Obj.PlaceName,
                        Value = Obj.Id.ToString()
                    });
                }
            }
            else
            {
                DDL_PlacetList.Add(new SelectListItem
                {
                    Selected = true,
                    Text = "-- Select --",
                    Value = "-1"
                });
                foreach (var Obj in PlaceList)
                {
                    DDL_PlacetList.Add(new SelectListItem
                    {
                        Selected = false,
                        Text = Obj.PlaceName,
                        Value = Obj.Id.ToString()
                    });
                }
            }
            ViewBag.PlaceID = DDL_PlacetList;
        }

        [HttpPost]
        public ActionResult Manage(tbl_People Obj, int Status = 0)
        {
            string Result = "";
            if (Status == 0)
            {
                int Count = context.tbl_People.Where(e => e.Name == Obj.Name && e.Status == "A").Count();
                if (Count > 0)
                {
                    Result = "Already Exist";
                }
                else
                {
                    context.tbl_People.Add(Obj);
                    context.SaveChanges();
                    Result = "Success";
                }
            }
            else
            {
                tbl_People retun_Obj = context.tbl_People.Where(e => e.Id == Obj.Id && e.Status != "D").SingleOrDefault();
                retun_Obj.Name = Obj.Name;
                retun_Obj.DateOfBirth = Obj.DateOfBirth;
                retun_Obj.Address = Obj.Address;
                retun_Obj.Phone = Obj.Phone;
                retun_Obj.Image = Obj.Image;
                retun_Obj.Place = Obj.Place;
                retun_Obj.Status = Obj.Status;
                context.Entry(retun_Obj).State = EntityState.Modified;
                context.SaveChanges();
                Result = "Success";
            }
            return Json(new { Result = Result }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UploadFile(HttpPostedFileBase fileData)
        {
            if (fileData != null)
            {
                try
                {
                    HttpPostedFileBase myFile = fileData;
                    if (myFile != null)
                    {
                        string savepath = Server.MapPath("~/Images");
                        String savethumbImagePath = savepath + @"\" + myFile.FileName;
                        myFile.SaveAs(savethumbImagePath);
                    }
                }


                catch (Exception ex)
                {
                    ex.ToString();
                }
            }

           // return RedirectToAction("Index");

            return Json("Success");
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

        public ActionResult _DetailView(int Id = 0)
        {
            tbl_People obj = context.tbl_People.Where(e => e.Id == Id && e.Status != "D").SingleOrDefault();
            return PartialView("_DetailView", obj);
        }

        public ActionResult Delete(int Id)
        {
            string Result = "";
            tbl_People regObj = context.tbl_People.Where(e => e.Id == Id && e.Status != "D").SingleOrDefault();
            if (regObj != null)
            {
                regObj.Status = "D";
                context.SaveChanges();
                Result = "Success";
            }
            else
            {
                Result = "Error";
            }
            return Json(new { Result = Result }, JsonRequestBehavior.AllowGet);
           
        }

        //
        // POST: /Admin/Delete/5

        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here
 
        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
