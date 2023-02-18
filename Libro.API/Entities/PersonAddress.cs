using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Libro.API.Entities
{
    public class PersonAddress
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("PersonId")]
        public Person? Person { get; set; }
        public int PersonId { get; set; }
        [ForeignKey("AddressId")]
        public Address? Address { get; set; }
        public int AddressId { get; set; }
        public bool IsFiscal { get; set; } = false;
    }
}
