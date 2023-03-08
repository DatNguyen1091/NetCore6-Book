using System.ComponentModel.DataAnnotations;

namespace NetCore6_Book.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }
        public string? Description { get; set; }

        [Range(0, double.MaxValue)]
        public double Price { get; set; }
        [Range(0, 500)]
        public int Quantity { get; set; }
    }
}
