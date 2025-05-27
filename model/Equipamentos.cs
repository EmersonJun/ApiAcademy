namespace EquipamentosApi.Models
{
    public class Equipamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime DataAquisicao { get; set; }
        public string Status { get; set; }
        public string? Descricao { get; set; }
    }
}
