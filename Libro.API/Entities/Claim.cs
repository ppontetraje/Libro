using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libro.API.Entities
{
    public class Claim
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Description { get; set; }
        [Required]
        [MaxLength(800)]
        public string Request { get; set; }
        [Required]
        [MaxLength(800)]
        public string Response { get; set; }
        [Required]
        public decimal ClaimedAmount { get; set; }
        [ForeignKey("AgencyId")]
        public Agency Agency { get; set; }
        public int AgencyId{ get; set; }
        [ForeignKey("PersonId")]
        public Person Person { get; set; }
        public int PersonId { get; set; }
    }
}
