using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinalGrupo_1.Data;
using ProyectoFinalGrupo_1.Models;

namespace ProyectoFinalGrupo_1.Services
{
    public class EventService 
    {
        private readonly ApplicationDbContext _context;

        public EventService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Event> GetAll() => _context.Eventos.ToList();

        public Event GetById(int id) => _context.Eventos.FirstOrDefault(e => e.Id == id);

        public void Add(Event evento)
        {
            _context.Eventos.Add(evento);
            _context.SaveChanges();
        }

        public void Update(Event evento)
        {
            _context.Eventos.Update(evento);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var evento = GetById(id);
            if (evento != null)
            {
                _context.Eventos.Remove(evento);
                _context.SaveChanges();
            }
        }
    }
}
