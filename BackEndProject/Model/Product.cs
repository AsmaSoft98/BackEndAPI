using System.ComponentModel.DataAnnotations;

namespace BackEndProject.Model
{
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }
        
        [Required(ErrorMessage = "Product Name is Required")]
        [StringLength(50)]
        public string Name { get; set; }
        public int PurchasePrice { get; set; }
        public int SalePrice { get; set; }
       
        [StringLength(50)]
        public string Stock { get; set; }
    }
}
