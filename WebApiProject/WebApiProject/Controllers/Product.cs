using System.ComponentModel.DataAnnotations;

namespace WebApiProject.Controllers
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        [Required]
        public string Description { get; set; }
    }
}