﻿using System;
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
    public class TipoComodidadesController : Controller
    {
        private Contexto db = new Contexto();

        // GET: TipoComodidades
        public ActionResult Index()
        {
            return View(db.Tiposcomodidades.ToList());
        }

        // GET: TipoComodidades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoComodidade tipoComodidade = db.Tiposcomodidades.Find(id);
            if (tipoComodidade == null)
            {
                return HttpNotFound();
            }
            return View(tipoComodidade);
        }

        // GET: TipoComodidades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoComodidades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descricao")] TipoComodidade tipoComodidade)
        {
            if (ModelState.IsValid)
            {
                db.Tiposcomodidades.Add(tipoComodidade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoComodidade);
        }

        // GET: TipoComodidades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoComodidade tipoComodidade = db.Tiposcomodidades.Find(id);
            if (tipoComodidade == null)
            {
                return HttpNotFound();
            }
            return View(tipoComodidade);
        }

        // POST: TipoComodidades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descricao")] TipoComodidade tipoComodidade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoComodidade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoComodidade);
        }

        // GET: TipoComodidades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoComodidade tipoComodidade = db.Tiposcomodidades.Find(id);
            if (tipoComodidade == null)
            {
                return HttpNotFound();
            }
            return View(tipoComodidade);
        }

        // POST: TipoComodidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoComodidade tipoComodidade = db.Tiposcomodidades.Find(id);
            db.Tiposcomodidades.Remove(tipoComodidade);
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
