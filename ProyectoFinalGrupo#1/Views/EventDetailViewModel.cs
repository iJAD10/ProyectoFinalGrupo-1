using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoFinalGrupo_1.Views
{
    public class EventDetailViewModel : Controller
    {
        // GET: EventDetailViewModel
        public ActionResult Index()
        {
            return View();
        }

        // GET: EventDetailViewModel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EventDetailViewModel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventDetailViewModel/Create
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

        // GET: EventDetailViewModel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EventDetailViewModel/Edit/5
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

        // GET: EventDetailViewModel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EventDetailViewModel/Delete/5
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
