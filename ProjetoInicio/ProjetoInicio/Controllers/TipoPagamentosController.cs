using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetoInicio.Models;

namespace ProjetoInicio.Controllers
{
    public class TipoPagamentosController : Controller
    {
        private Contexto db = new Contexto();

        // GET: TipoPagamentos
        public ActionResult Index()
        {
            return View(db.TipoPagamentoes.ToList());
        }

        // GET: TipoPagamentos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoPagamento tipoPagamento = db.TipoPagamentoes.Find(id);
            if (tipoPagamento == null)
            {
                return HttpNotFound();
            }
            return View(tipoPagamento);
        }

        // GET: TipoPagamentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoPagamentos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descricao,Intervalo")] TipoPagamento tipoPagamento)
        {
            if (ModelState.IsValid)
            {
                db.TipoPagamentoes.Add(tipoPagamento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoPagamento);
        }

        // GET: TipoPagamentos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoPagamento tipoPagamento = db.TipoPagamentoes.Find(id);
            if (tipoPagamento == null)
            {
                return HttpNotFound();
            }
            return View(tipoPagamento);
        }

        // POST: TipoPagamentos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descricao,Intervalo")] TipoPagamento tipoPagamento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoPagamento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoPagamento);
        }

        // GET: TipoPagamentos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoPagamento tipoPagamento = db.TipoPagamentoes.Find(id);
            if (tipoPagamento == null)
            {
                return HttpNotFound();
            }
            return View(tipoPagamento);
        }

        // POST: TipoPagamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoPagamento tipoPagamento = db.TipoPagamentoes.Find(id);
            db.TipoPagamentoes.Remove(tipoPagamento);
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
