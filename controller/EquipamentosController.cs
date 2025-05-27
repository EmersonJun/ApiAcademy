using Microsoft.AspNetCore.Mvc;
using EquipamentosApi.Models;
using EquipamentosApi.Services;

namespace EquipamentosApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquipamentosController : ControllerBase
    {
        private readonly EquipamentoService _service;

        public EquipamentosController(EquipamentoService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Equipamento>> Get() => _service.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Equipamento> Get(int id)
        {
            var eq = _service.GetById(id);
            if (eq == null) return NotFound();
            return eq;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Equipamento equipamento)
        {
            _service.Add(equipamento);
            return CreatedAtAction(nameof(Get), new { id = equipamento.Id }, equipamento);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _service.Delete(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}
