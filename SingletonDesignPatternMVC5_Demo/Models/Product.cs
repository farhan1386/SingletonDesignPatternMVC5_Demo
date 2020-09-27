using System.ComponentModel.DataAnnotations;

namespace SingletonDesignPatternMVC5_Demo.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }
    }
}