using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoFinalGrupo_1.Services
{
    public class EventService : Controller
    {
        // GET: EventService
        public ActionResult Index()
        {
            return View();
        }

        // GET: EventService/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EventService/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventService/Create
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

        // GET: EventService/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EventService/Edit/5
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

        // GET: EventService/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EventService/Delete/5
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
