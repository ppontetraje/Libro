using System.ComponentModel.DataAnnotations;

namespace Libro.API.Models
{
    public class PersonaDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Denominacion {
            get
            {
                return $"{LastName} {Name}";
            }
        }
    }
}
