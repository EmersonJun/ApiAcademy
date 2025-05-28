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
                new Equipamento { Nome = "Esteira Elétrica", Tipo = "Cardio", Marca = "Movement", Modelo = "RT250", DataAquisicao = DateTime.Parse("2021-01-15"), Status = "Em uso", Descricao = "Esteira profissional para corrida" },
                new Equipamento { Nome = "Bicicleta Ergométrica", Tipo = "Cardio", Marca = "Kikos", Modelo = "KR9.1", DataAquisicao = DateTime.Parse("2020-08-10"), Status = "Disponível", Descricao = "Bicicleta vertical com monitor" },
                new Equipamento { Nome = "Leg Press", Tipo = "Musculação", Marca = "Life Fitness", Modelo = "Signature", DataAquisicao = DateTime.Parse("2019-04-22"), Status = "Em uso", Descricao = "Aparelho de treino de pernas" },
                new Equipamento { Nome = "Banco Supino", Tipo = "Musculação", Marca = "Body Solid", Modelo = "GFID31", DataAquisicao = DateTime.Parse("2021-11-12"), Status = "Disponível", Descricao = "Banco ajustável para supino" },
                new Equipamento { Nome = "Remo Indoor", Tipo = "Cardio", Marca = "Concept2", Modelo = "Model D", DataAquisicao = DateTime.Parse("2022-06-01"), Status = "Em uso", Descricao = "Equipamento de remo para treino completo" },
                new Equipamento { Nome = "Halter 10kg", Tipo = "Musculação", Marca = "Nautilus", Modelo = "Dumbbell10", DataAquisicao = DateTime.Parse("2023-02-18"), Status = "Em uso", Descricao = "Par de halteres de 10kg" },
                new Equipamento { Nome = "Barra Olímpica", Tipo = "Musculação", Marca = "Rogue", Modelo = "Olympic 20kg", DataAquisicao = DateTime.Parse("2023-03-05"), Status = "Em uso", Descricao = "Barra olímpica para levantamento" },
                new Equipamento { Nome = "Corda Naval", Tipo = "Funcional", Marca = "ProAction", Modelo = "Battle Rope", DataAquisicao = DateTime.Parse("2022-10-22"), Status = "Disponível", Descricao = "Corda para exercícios funcionais" },
                new Equipamento { Nome = "Bola Bosu", Tipo = "Equilíbrio", Marca = "Bosu", Modelo = "Pro Balance", DataAquisicao = DateTime.Parse("2021-09-19"), Status = "Disponível", Descricao = "Bola para treino de equilíbrio" },
                new Equipamento { Nome = "Elíptico", Tipo = "Cardio", Marca = "Johnson", Modelo = "Horizon EX-59", DataAquisicao = DateTime.Parse("2020-12-11"), Status = "Em uso", Descricao = "Elíptico com monitor de desempenho" }
            };
                        // Adiciona ao banco
            context.Equipamentos.AddRange(equipamentos);
            context.SaveChanges();
        }
    }
}
