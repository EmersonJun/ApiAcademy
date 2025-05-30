# Atividade Avaliativa - Projeto API em C#

## Integrantes do Grupo
- Emerson Junior  
- Taynara Mafra  
- Kayo Henrique  

## Funcionalidades Implementadas
1. Cadastro de Equipamentos  
2. Listagem de Todos os Equipamentos  
3. Consulta de Equipamento por ID  
4. Remoção de Equipamento por ID  

## Descrição Funcional das Funcionalidades

1. **Cadastro de Equipamentos:**  
   Permite adicionar novos equipamentos à base de dados informando dados como nome, tipo, marca, modelo, status e data de aquisição.

2. **Listagem de Todos os Equipamentos:**  
   Retorna a lista completa de equipamentos registrados no sistema, com todos os seus atributos.

3. **Consulta de Equipamento por ID:**  
   Permite buscar os dados detalhados de um equipamento específico por meio do seu ID.

4. **Remoção de Equipamento por ID:**  
   Remove permanentemente um equipamento da base de dados com base no seu ID.

---

## Documentação Detalhada de Dois Recursos

### 1. **Cadastro de Equipamentos**

#### Lógica:
1. O usuário envia um `POST` para a rota `/api/equipamentos`.
2. A API valida e registra o equipamento no banco de dados.
3. Os dados obrigatórios incluem:
   - Nome
   - Tipo
   - Marca
   - Modelo
   - Data de Aquisição
   - Status de Uso
   - Descrição (opcional)

#### Estruturas Utilizadas:
- **Classe Equipamento**: Representa o modelo de dados.
- **Entity Framework Core**: Responsável por interações com o banco.
- **Método POST no Controller**: Recebe e processa o cadastro.

#### Justificativa:
Esse recurso é essencial para manter atualizado o inventário da academia. A separação das responsabilidades garante que a lógica de persistência esteja isolada na camada de serviço, favorecendo manutenção e escalabilidade.

---

### 2. **Consulta de Equipamento por ID**

#### Lógica:
1. O usuário faz uma requisição `GET` para a rota `/api/equipamentos/{id}`.
2. A API busca no banco o equipamento correspondente ao ID.
3. Se encontrado, retorna os dados; caso contrário, retorna `NotFound`.

#### Estruturas Utilizadas:
- **Rota com parâmetro de URL**: Para captura dinâmica do ID.
- **Método GET no Controller**: Responsável pela lógica de consulta.
- **LINQ/EF Core**: Para busca do registro no banco de dados.

#### Justificativa:
Permitir consultas individuais facilita integrações futuras com painéis administrativos ou aplicações mobile, além de manter a API aderente a boas práticas REST.

---

## Organização do Código
O projeto foi estruturado de forma modular, com separação de responsabilidades:

- **Models/Equipamento.cs**: Define os atributos da entidade Equipamento.  
- **Data/AppDbContext.cs**: Responsável pela configuração da base de dados (usando EF Core e SQLite).  
- **Data/DbInitializer.cs**: Realiza a criação e migração do banco de dados.  
- **Services/EquipamentoService.cs**: Contém a lógica de negócio da aplicação.  
- **Controllers/EquipamentosController.cs**: Define os endpoints da API.  
- **Program.cs**: Configura a aplicação e inicializa os serviços no startup.

---

### Endpoints da API

| Método | Rota                         | Descrição                         |
|--------|------------------------------|-----------------------------------|
| GET    | /api/equipamentos            | Retorna todos os equipamentos     |
| GET    | /api/equipamentos/{id}       | Retorna um equipamento por ID     |
| POST   | /api/equipamentos            | Adiciona um novo equipamento      |
| DELETE | /api/equipamentos/{id}       | Remove um equipamento por ID      |
