using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoFinalGrupo_1.Models
{
    public class Seat : Controller
    {
        // GET: Seat
        public ActionResult Index()
        {
            return View();
        }

        // GET: Seat/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Seat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Seat/Create
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

        // GET: Seat/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Seat/Edit/5
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

        // GET: Seat/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Seat/Delete/5
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
