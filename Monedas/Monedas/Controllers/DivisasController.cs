using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Monedas.Cross_Cutting.Exception;
using Monedas.Domain.Context;
using Monedas.Domain.Models;
using Monedas.Services.Factory;
using Monedas.Services.Repository;

namespace Monedas.Controllers
{
    public class DivisasController : Controller
    {
        private MonedasContext db = new MonedasContext();
        private DivisasRepository _repository;

        public DivisasController(DivisasRepository repository)
        {
            _repository = repository;
        }
        
        // GET: Divisas
        public async Task<ActionResult> Index()
        {
            try
            {
                return View(await db.Divisas.ToListAsync());
            }

            catch(Exception ex)
            {
                throw new ControllerException("Error inesperado en DivisasController");
            }
        }

       

        // GET: Divisas/Create
        public async Task<ActionResult> Create()
        {
            try
            {
                await _repository.All_Delete();
                IListaDivisasFactory factory = new ListaDivisasFactory();
                var lista = factory.CrearLista(_repository.ruta);
                await _repository.Insert(lista);
                return View();
            }
            catch (Exception ex)
            {
                throw new ControllerException("Error inesperado en DivisasController");
            }

        }



        // POST: Divisas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Create([Bind(Include = "Id,from,to,rate")] Divisas divisas)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Divisas.Add(divisas);
        //        await db.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }

        //    return View(divisas);
        //}

        //// GET: Divisas/Edit/5
        //public async Task<ActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Divisas divisas = await db.Divisas.FindAsync(id);
        //    if (divisas == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(divisas);
        //}

        //// POST: Divisas/Edit/5
        //// Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        //// más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Edit([Bind(Include = "Id,from,to,rate")] Divisas divisas)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(divisas).State = EntityState.Modified;
        //        await db.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }
        //    return View(divisas);
        //}

        //// GET: Divisas/Delete/5
        //public async Task<ActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Divisas divisas = await db.Divisas.FindAsync(id);
        //    if (divisas == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(divisas);
        //}

        //// POST: Divisas/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> DeleteConfirmed(int id)
        //{
        //    Divisas divisas = await db.Divisas.FindAsync(id);
        //    db.Divisas.Remove(divisas);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

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
