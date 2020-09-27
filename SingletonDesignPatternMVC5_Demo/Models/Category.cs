using System.ComponentModel.DataAnnotations;

namespace SingletonDesignPatternMVC5_Demo.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Category")]
        public string CategoryName { get; set; }
    }
}