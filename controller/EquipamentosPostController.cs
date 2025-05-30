using Microsoft.AspNetCore.Mvc;
using EquipamentosApi.Models;

namespace EquipamentosApi.Controllers
{
    public partial class EquipamentosController
    {
        [HttpPost]
        public IActionResult Post([FromBody] Equipamento equipamento)
        {
            _service.Add(equipamento);
            return CreatedAtAction(nameof(Get), new { id = equipamento.Id }, equipamento);
        }
    }
}
