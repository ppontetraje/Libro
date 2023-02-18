using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Libro.API.Entities
{
    public class PersonDocument
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("PersonId")]
        public Person? Person { get; set; }
        public int PersonId { get; set; }
        [ForeignKey("DocumentId")]
        public Document? Document { get; set; }
        public int DocumentId { get; set; }
        public string Serie { get; set; }
        [Required]
        public string Number { get; set; }
    }
}
