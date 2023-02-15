using System.ComponentModel.DataAnnotations;

namespace Libro.API.Models
{
    public class PersonaForCreationDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(70)]
        public string LastName { get; set; }
    }
}