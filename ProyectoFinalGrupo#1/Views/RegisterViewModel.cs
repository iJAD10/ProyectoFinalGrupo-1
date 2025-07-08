using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoFinalGrupo_1.Views
{
    public class RegisterViewModel : Controller
    {
        // GET: RegisterViewModel
        public ActionResult Index()
        {
            return View();
        }

        // GET: RegisterViewModel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegisterViewModel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegisterViewModel/Create
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

        // GET: RegisterViewModel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegisterViewModel/Edit/5
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

        // GET: RegisterViewModel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegisterViewModel/Delete/5
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
