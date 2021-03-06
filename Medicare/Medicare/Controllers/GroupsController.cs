﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Medicare.BLL;
using Medicare.Models;

namespace Medicare.Controllers
{
    public class GroupsController : Controller
    {
        private MedicareDbContext db = new MedicareDbContext();

        // GET: Groups
        public ActionResult Index()
        {
            return View(db.Groupses.ToList());
        }

        // GET: Groups/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Groups groups = db.Groupses.Find(id);
            if (groups == null)
            {
                return HttpNotFound();
            }
            return View(groups);
        }

        // GET: Groups/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Groups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GroupsId,GroupName")] Groups groups)
        {
            GroupsManager groupsManager = new GroupsManager();
            try
            {


                if (ModelState.IsValid)
                {
                    if (groupsManager.IsNameExist(groups))
                    {
                        ViewBag.ErrorMessage = "Name Already Exist";
                        return View();
                    }
                    else
                    {
                        db.Groupses.Add(groups);
                        db.SaveChanges();
                        ViewBag.successMessage = "Save Successfully";
                        return RedirectToAction("Index");
                    }
                }
                
            }
            catch (Exception exception)
            {
                ViewBag.ExceptionMessage = exception.Message;
            }
            return View(groups);
            
        }
    


    // GET: Groups/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Groups groups = db.Groupses.Find(id);
            if (groups == null)
            {
                return HttpNotFound();
            }
            return View(groups);
        }

        // POST: Groups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GroupsId,GroupName")] Groups groups)
        {
            if (ModelState.IsValid)
            {
                db.Entry(groups).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(groups);
        }

        // GET: Groups/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Groups groups = db.Groupses.Find(id);
            if (groups == null)
            {
                return HttpNotFound();
            }
            return View(groups);
        }

        // POST: Groups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Groups groups = db.Groupses.Find(id);
            db.Groupses.Remove(groups);
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

        public JsonResult IsNameExist(string GroupName)
        {
            return Json(!db.Groupses.Any(x => x.GroupName == GroupName),
                                         JsonRequestBehavior.AllowGet);
        }
    }
}
