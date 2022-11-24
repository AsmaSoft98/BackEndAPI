using System.ComponentModel.DataAnnotations;

namespace BackEndProject.Model
{
    public class Employee
    {
        [Key]
        public int IdEmployee { get; set; }
        
        [StringLength(50)]
        public string Name { get; set; }
        
        [StringLength(50)]
        public string LastName { get; set; }
        
        [StringLength(100)]
        public string Profession { get; set; }
        
        [StringLength(100)]
        public string Email { get; set; }
        
        [StringLength(50)]
        public string Department { get; set; }
        public int Salary { get; set; }
    }
}
