using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealthDeclarationSolution.Models
{
    public class HealthDeclarationViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string BusinessEmail { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public string Designation { get; set; }
        [Required]
        public string BusinessNumber { get; set; }
        public string LicensePlate { get; set; }
        [Required]
        public string NRIC { get; set; }
        public string IsStayHome { get; set; }
        public string IsContact { get; set; }
        public string IsFever { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
