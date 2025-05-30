using Microsoft.AspNetCore.Mvc;
using EquipamentosApi.Models;
using EquipamentosApi.Services;
using System.Collections.Generic;

namespace EquipamentosApi.Controllers
{
    public partial class EquipamentosController
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
    }
}
