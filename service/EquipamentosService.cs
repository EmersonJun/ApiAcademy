using EquipamentosApi.Models;

namespace EquipamentosApi.Services
{
    public class EquipamentoService
    {
        private static List<Equipamento> equipamentos = new()
        {
            new Equipamento { Id = 1, Nome = "Bicicleta Ergométrica", Tipo = "Cardio", Marca = "Life", Modelo = "X100", DataAquisicao = DateTime.Now.AddYears(-2), Status = "ativo", Descricao = "Boa para iniciantes" },
            new Equipamento { Id = 2, Nome = "Supino Reto", Tipo = "Musculação", Marca = "StrongFit", Modelo = "SR300", DataAquisicao = DateTime.Now.AddYears(-1), Status = "ativo", Descricao = "Modelo robusto" }
            // Adicione até 10
        };

        public List<Equipamento> GetAll() => equipamentos;

        public Equipamento? GetById(int id) => equipamentos.FirstOrDefault(e => e.Id == id);

        public void Add(Equipamento e)
        {
            e.Id = equipamentos.Max(x => x.Id) + 1;
            equipamentos.Add(e);
        }

        public bool Delete(int id)
        {
            var equipamento = GetById(id);
            if (equipamento != null)
                return equipamentos.Remove(equipamento);
            return false;
        }
    }
}
