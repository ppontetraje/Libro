using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libro.API.Entities
{
    public class Document
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(15)]
        public string Acronym { get; set; }
        public string SunatCode { get; set; }
        [ForeignKey("DocumentTypeId")]
        public DocumentType? DocumentType { get; set; }
        public int DocumentTypeId { get; set; }
        [Required]
        public bool HasSerie { get; set; }
    }
}
