using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoFinalGrupo_1.Services
{
    public class UserService : Controller
    {
        // GET: UserService
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserService/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserService/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserService/Create
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

        // GET: UserService/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserService/Edit/5
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

        // GET: UserService/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserService/Delete/5
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
