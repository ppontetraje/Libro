using Libro.API.Models;
using Libro.API.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Libro.API.Controllers
{
    [Route("api/personas")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly ILogger<PersonaController> _logger;

        private readonly IMailService _mailService;
        private readonly PersonaDataStore _personaDataStore;

        public PersonaController(ILogger<PersonaController> logger, 
            IMailService mailService,
            PersonaDataStore personaDataStore)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mailService = mailService ?? throw new ArgumentNullException(nameof(mailService));
            _personaDataStore = personaDataStore;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PersonaDto>> GetPersonas()
        {
            return Ok(_personaDataStore.personas);
        }
        [HttpGet("{id}", Name = "GetPersona")]
        public ActionResult<PersonaDto> GetPersona(int id)
        {
            try
            {
                //throw new Exception("Exception Sample");
                var personasToReturn = _personaDataStore.personas.FirstOrDefault(c => c.Id == id);
                if (personasToReturn == null)
                {
                    _logger.LogInformation($"La persona con id: {id} no existe!");
                    return NotFound();
                }
                return Ok(personasToReturn);
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"Excepción mientras se busca una persona con id {id}.", ex);
                return StatusCode(500, "Ocurrió un problema mientras se ejecutaba la consulta.");
            }
        }

    [HttpPost]
        public ActionResult<PersonaDto> CreatePersona(PersonaForCreationDto persona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var finalPersona = new PersonaDto()
            {
                Id = _personaDataStore.personas.Count() + 1,
                Name = persona.Name,
                LastName = persona.LastName
            };
            _personaDataStore.personas.Add(finalPersona);
            return CreatedAtRoute("GetPersona",
                new { finalPersona.Id },
                finalPersona);

        }
        [HttpPut("{personaId}")]
        public ActionResult UpdatePersona(int personaId,
            PersonaForUpdateDto persona)
        {
            var oPersona = _personaDataStore.personas.FirstOrDefault(c => c.Id == personaId);
            if (oPersona == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            oPersona.Name = persona.Name;
            oPersona.LastName = persona.LastName;

            return NoContent();
        }
        [HttpPatch("{personaId}")]
        public ActionResult PartiallyUpdatePersona(int personaId,
            JsonPatchDocument<PersonaForUpdateDto> patchDocument)
        {
            var oPersona = _personaDataStore.personas.FirstOrDefault(c => c.Id == personaId);
            if (oPersona == null)
            {
                return NotFound();
            }

            var personaTopatch = new PersonaForUpdateDto()
            {
                Name = oPersona.Name,
                LastName = oPersona.LastName
            };
            
            patchDocument.ApplyTo(personaTopatch, ModelState);
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!TryValidateModel(personaTopatch))
            {
                return BadRequest(ModelState);
            }
            oPersona.Name = personaTopatch.Name;
            oPersona.LastName = personaTopatch.LastName;
            return NoContent();
        }
        [HttpDelete("{personaId}")]
        public ActionResult DeletePersona(int personaId)
        {
            var oPersona = _personaDataStore.personas.FirstOrDefault(c => c.Id == personaId);
            if (oPersona == null)
            {
                return NotFound();
            }
            _personaDataStore.personas.Remove(oPersona);
            _mailService.Send("Persona eliminada",
                $"El registro de la persona: {oPersona.Denominacion} fué eliminado.");
            return NoContent();

        }
    }
}
     