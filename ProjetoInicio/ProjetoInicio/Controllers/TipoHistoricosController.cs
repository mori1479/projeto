using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetoInicio.Models;
using WebApplication1.Models;

namespace ProjetoInicio.Controllers
{
    public class TipoHistoricosController : Controller
    {
        private Contexto db = new Contexto();

        // GET: TipoHistoricos
        public ActionResult Index()
        {
            return View(db.TiposHistoricos.ToList());
        }

        // GET: TipoHistoricos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoHistorico tipoHistorico = db.TiposHistoricos.Find(id);
            if (tipoHistorico == null)
            {
                return HttpNotFound();
            }
            return View(tipoHistorico);
        }

        // GET: TipoHistoricos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoHistoricos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descricao")] TipoHistorico tipoHistorico)
        {
            if (ModelState.IsValid)
            {
                db.TiposHistoricos.Add(tipoHistorico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoHistorico);
        }

        // GET: TipoHistoricos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoHistorico tipoHistorico = db.TiposHistoricos.Find(id);
            if (tipoHistorico == null)
            {
                return HttpNotFound();
            }
            return View(tipoHistorico);
        }

        // POST: TipoHistoricos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descricao")] TipoHistorico tipoHistorico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoHistorico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoHistorico);
        }

        // GET: TipoHistoricos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoHistorico tipoHistorico = db.TiposHistoricos.Find(id);
            if (tipoHistorico == null)
            {
                return HttpNotFound();
            }
            return View(tipoHistorico);
        }

        // POST: TipoHistoricos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoHistorico tipoHistorico = db.TiposHistoricos.Find(id);
            db.TiposHistoricos.Remove(tipoHistorico);
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
