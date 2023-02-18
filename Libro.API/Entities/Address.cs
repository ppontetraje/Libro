using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libro.API.Entities
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(125)]
        public string Description { get; set; }
        [Required]
        [MaxLength(6)]
        public string Ubigeo { get; set; }
        public DateTime DateRegistered { get; set; } = DateTime.Now;
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set;}
        [MaxLength(60)]
        public string Reference { get; set; }
        public bool Status { get; set; } = true;

    }
}
