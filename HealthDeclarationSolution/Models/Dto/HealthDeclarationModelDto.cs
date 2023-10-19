namespace HealthDeclarationSolution.Models.Dto
{
    public class HealthDeclarationModelDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BusinessEmail { get; set; }
        public string CompanyName { get; set; }
        public string Designation { get; set; }
        public string BusinessNumber { get; set; }
        public string LicensePlate { get; set; }
        public string NRIC { get; set; }
        public string IsStayHome { get; set; }
        public string IsContact { get; set; }
        public string IsFever { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
