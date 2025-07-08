using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoFinalGrupo_1.Services
{
    public class TicketService : Controller
    {
        // GET: TicketService
        public ActionResult Index()
        {
            return View();
        }

        // GET: TicketService/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TicketService/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TicketService/Create
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

        // GET: TicketService/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TicketService/Edit/5
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

        // GET: TicketService/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TicketService/Delete/5
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
