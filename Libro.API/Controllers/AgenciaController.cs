using Libro.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Libro.API.Controllers
{
    [ApiController]
    [Route("api/agencias")]
    public class AgenciaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<AgenciaDto>> GetAgencias()
        {
            return Ok(AgenciaDataStore.Current.Agencias);
        }
        [HttpGet("{id}")]
        public ActionResult<AgenciaDto> GetAgencia(int id)
        {
            var agenciaToReturn = AgenciaDataStore.Current.Agencias.FirstOrDefault(c=> c.Id == id);
            if(agenciaToReturn == null)
                return NotFound();
            return Ok(agenciaToReturn);
        }
    }
}
