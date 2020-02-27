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
using Monedas.Models.Domain;
using Monedas.Services.Factory;
using Monedas.Services.Repository;

namespace Monedas.Controllers
{
    public class TransaccionesController : Controller
    {
        private MonedasContext db = new MonedasContext();
        private TransaccionesRepository _repository;

        public TransaccionesController(TransaccionesRepository repository)
        {
            _repository = repository;
        }

        // GET: Divisas
        public async Task<ActionResult> Index()
        {
            try
            {
                return View(await db.Transaccioneses.ToListAsync());
            }

            catch (Exception ex)
            {
                throw new ControllerException("Error inesperado en TransaccionesController");
            }
        }



        // GET: Divisas/Create
        public async Task<ActionResult> Create()
        {
            try
            {
                await _repository.All_Delete();
                IListaTransaccionesFactory factory = new ListaTransaccionesFactory();
                var lista = factory.CrearLista(_repository.ruta);
                await _repository.Insert(lista);
                return View();
            }
            catch (Exception ex)
            {
                throw new ControllerException("Error inesperado en TransaccionesController");
            }

        }


        // GET: Transacciones/Details/5
        //public async Task<ActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Transacciones transacciones = await db.Transaccioneses.FindAsync(id);
        //    if (transacciones == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(transacciones);
        //}

        // GET: Transacciones/Create
     

        // POST: Transacciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Create([Bind(Include = "Id,sku,amount,currency")] Transacciones transacciones)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Transaccioneses.Add(transacciones);
        //        await db.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }

        //    return View(transacciones);
        //}

        //// GET: Transacciones/Edit/5
        //public async Task<ActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Transacciones transacciones = await db.Transaccioneses.FindAsync(id);
        //    if (transacciones == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(transacciones);
        //}

        //// POST: Transacciones/Edit/5
        //// Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        //// más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Edit([Bind(Include = "Id,sku,amount,currency")] Transacciones transacciones)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(transacciones).State = EntityState.Modified;
        //        await db.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }
        //    return View(transacciones);
        //}

        //// GET: Transacciones/Delete/5
        //public async Task<ActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Transacciones transacciones = await db.Transaccioneses.FindAsync(id);
        //    if (transacciones == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(transacciones);
        //}

        //// POST: Transacciones/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> DeleteConfirmed(int id)
        //{
        //    Transacciones transacciones = await db.Transaccioneses.FindAsync(id);
        //    db.Transaccioneses.Remove(transacciones);
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
