using System.ComponentModel.DataAnnotations;

namespace BackEndProject.Model
{
    public class Supplier
    {
        [Key]
        public int IdSupplier { get; set; }
        
        [Required(ErrorMessage = "Supplier Name is Required")]
        [StringLength(50)]
        public string Name { get; set; }
        
        [StringLength(50)]
        [RegularExpression(@"^[A-Z&Ñ]{3,4}[0-9]{2}(0[1-9]|1[012])(0[1-9]|[12][0-9]|3[01])[A-Z0-9]{2}[0-9A]$",
                                        ErrorMessage = "Invalid Code")]
        public string codeFiscal { get; set; }
        public int Point { get; set; }
        
        [StringLength(50)]
        public string Service { get; set; }
    }
}
