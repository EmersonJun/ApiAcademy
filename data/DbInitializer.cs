using EquipamentosApi.Models;

namespace EquipamentosApi.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            // Verifica se já existem registros
            if (context.Equipamentos.Any())
                return;

            // Cria uma lista de 10 equipamentos
            var equipamentos = new List<Equipamento>
            {
                new Equipamento { Nome = "Notebook A", Tipo = "Computador", Marca = "Dell", Modelo = "Inspiron 15", DataAquisicao = DateTime.Parse("2021-03-15"), Status = "Em uso", Descricao = "Notebook de uso geral" },
                new Equipamento { Nome = "Projetor Epson", Tipo = "Projetor", Marca = "Epson", Modelo = "X39", DataAquisicao = DateTime.Parse("2020-11-02"), Status = "Disponível", Descricao = "Projetor de sala de reuniões" },
                new Equipamento { Nome = "Impressora Laser", Tipo = "Impressora", Marca = "HP", Modelo = "M404", DataAquisicao = DateTime.Parse("2019-09-20"), Status = "Em uso", Descricao = "Impressora da recepção" },
                new Equipamento { Nome = "Servidor Dell", Tipo = "Servidor", Marca = "Dell", Modelo = "PowerEdge T40", DataAquisicao = DateTime.Parse("2022-05-01"), Status = "Em uso", Descricao = "Servidor principal" },
                new Equipamento { Nome = "Monitor LG", Tipo = "Monitor", Marca = "LG", Modelo = "24MK430", DataAquisicao = DateTime.Parse("2021-07-12"), Status = "Disponível", Descricao = "Monitor extra" },
                new Equipamento { Nome = "Mouse Logitech", Tipo = "Periférico", Marca = "Logitech", Modelo = "M185", DataAquisicao = DateTime.Parse("2023-01-18"), Status = "Em uso", Descricao = "Mouse sem fio" },
                new Equipamento { Nome = "Teclado ABNT2", Tipo = "Periférico", Marca = "Multilaser", Modelo = "TC195", DataAquisicao = DateTime.Parse("2023-01-18"), Status = "Em uso", Descricao = "Teclado padrão" },
                new Equipamento { Nome = "Roteador TP-Link", Tipo = "Rede", Marca = "TP-Link", Modelo = "Archer C6", DataAquisicao = DateTime.Parse("2022-02-22"), Status = "Em uso", Descricao = "Roteador de escritório" },
                new Equipamento { Nome = "Cabo HDMI", Tipo = "Acessório", Marca = "Pix", Modelo = "2m", DataAquisicao = DateTime.Parse("2023-05-05"), Status = "Disponível", Descricao = "Cabo para projeção" },
                new Equipamento { Nome = "Switch de Rede", Tipo = "Rede", Marca = "Cisco", Modelo = "SG110-16", DataAquisicao = DateTime.Parse("2022-09-09"), Status = "Em uso", Descricao = "Switch principal" }
            };

            // Adiciona ao banco
            context.Equipamentos.AddRange(equipamentos);
            context.SaveChanges();
        }
    }
}
