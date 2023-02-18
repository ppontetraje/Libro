using System.ComponentModel.DataAnnotations;

namespace Libro.API.Entities
{
    public class DocumentType
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

    }
}
