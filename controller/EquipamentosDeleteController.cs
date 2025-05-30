using Microsoft.AspNetCore.Mvc;

namespace EquipamentosApi.Controllers
{
    public partial class EquipamentosController
    {
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _service.Delete(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}
