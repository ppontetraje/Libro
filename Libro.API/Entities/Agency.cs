using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Libro.API.Enums;

namespace Libro.API.Entities
{
    public class Agency
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public AgencyType AgencyType { get; set; }
        public bool Status { get; set; } = true;
        [ForeignKey("PersonId")]
        public Person Person { get; set; }
        public int PersonId { get; set; }

    }
}
