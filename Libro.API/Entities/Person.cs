using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libro.API.Entities
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(120)]
        public string Name { get; set; }
        [MaxLength(120)]
        public string LastName { get; set; }
        public char Genre { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
