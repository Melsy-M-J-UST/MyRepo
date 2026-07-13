using System.ComponentModel.DataAnnotations;

namespace Products.API.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        // Navigation Property (One-to-Many)
        public ICollection<Product> Products { get; set; }
    }
}

