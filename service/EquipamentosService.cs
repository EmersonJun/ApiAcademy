using EquipamentosApi.Models;
using EquipamentosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace EquipamentosApi.Services
{
    public class EquipamentoService
    {
        private readonly AppDbContext _context;

        public EquipamentoService(AppDbContext context)
        {
            _context = context;
        }

        public List<Equipamento> GetAll() =>
            _context.Equipamentos.ToList();

        public Equipamento? GetById(int id) =>
            _context.Equipamentos.Find(id);

        public void Add(Equipamento equipamento)
        {
            _context.Equipamentos.Add(equipamento);
            _context.SaveChanges();
        }

        public bool Delete(int id)
        {
            var eq = _context.Equipamentos.Find(id);
            if (eq == null) return false;

            _context.Equipamentos.Remove(eq);
            _context.SaveChanges();
            return true;
        }
    }
}
