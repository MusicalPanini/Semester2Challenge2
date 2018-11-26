using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sem2Challenge2.Models;

namespace Sem2Challenge2.Controllers
{
    public class GameModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: GameModels
        public ActionResult Index()
        {
            return View(db.GameModels.ToList());
        }

        // GET: GameModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameModels gameModels = db.GameModels.Find(id);
            if (gameModels == null)
            {
                return HttpNotFound();
            }
            return View(gameModels);
        }

        // GET: GameModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GameModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GameID,Venue,FeeAmount,GameDate")] GameModels gameModels)
        {
            if (ModelState.IsValid)
            {
                db.GameModels.Add(gameModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gameModels);
        }

        // GET: GameModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameModels gameModels = db.GameModels.Find(id);
            if (gameModels == null)
            {
                return HttpNotFound();
            }
            return View(gameModels);
        }

        // POST: GameModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GameID,Venue,FeeAmount,GameDate")] GameModels gameModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gameModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gameModels);
        }

        // GET: GameModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameModels gameModels = db.GameModels.Find(id);
            if (gameModels == null)
            {
                return HttpNotFound();
            }
            return View(gameModels);
        }

        // POST: GameModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GameModels gameModels = db.GameModels.Find(id);
            db.GameModels.Remove(gameModels);
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
    }
}
