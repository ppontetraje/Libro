using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libro.API.Entities
{
    public class AgencyAddress
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("AgencyId")]
        public Agency? Agency { get; set; }
        public int AgencyId { get; set; }
        [ForeignKey("AddressId")]
        public Address? Address { get; set; }
        public int AddressId { get; set; }
        public bool Current { get; set; } = true;
    }
}
