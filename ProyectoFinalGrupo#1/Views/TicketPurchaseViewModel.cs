using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoFinalGrupo_1.Views
{
    public class TicketPurchaseViewModel : Controller
    {
        // GET: TicketPurchaseViewModel
        public ActionResult Index()
        {
            return View();
        }

        // GET: TicketPurchaseViewModel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TicketPurchaseViewModel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TicketPurchaseViewModel/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TicketPurchaseViewModel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TicketPurchaseViewModel/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TicketPurchaseViewModel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TicketPurchaseViewModel/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
