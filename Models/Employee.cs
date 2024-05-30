namespace WAExamenParcial1.Models
{
    public class Employee : EntityModel
    {
        public string Role { get; set; }
        public decimal Salary { get; set; }
        public int Seniority { get; set; }
        
    }
}