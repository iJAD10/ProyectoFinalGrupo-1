using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinalGrupo_1.Data;
using ProyectoFinalGrupo_1.Models;

namespace ProyectoFinalGrupo_1.Controllers
{
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var eventos = _context.Eventos.ToList();
            return View(eventos);
        }

        public IActionResult Details(int id)
        {
            var evento = _context.Eventos.FirstOrDefault(e => e.Id == id);
            if (evento == null) return NotFound();
            return View(evento);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Event evento)
        {
            if (ModelState.IsValid)
            {
                _context.Eventos.Add(evento);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(evento);
        }

        public IActionResult Edit(int id)
        {
            var evento = _context.Eventos.FirstOrDefault(e => e.Id == id);
            if (evento == null) return NotFound();
            return View(evento);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Event evento)
        {
            if (ModelState.IsValid)
            {
                _context.Eventos.Update(evento);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(evento);
        }

        public IActionResult Delete(int id)
        {
            var evento = _context.Eventos.FirstOrDefault(e => e.Id == id);
            if (evento == null) return NotFound();
            return View(evento);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var evento = _context.Eventos.FirstOrDefault(e => e.Id == id);
            if (evento != null)
            {
                _context.Eventos.Remove(evento);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
