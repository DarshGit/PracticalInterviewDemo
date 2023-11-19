using System.ComponentModel.DataAnnotations;

namespace CognisunPractical.Data.Domain
{
    public class ProductMaster
    {
        [Required]
        public int Id { get; set; } 

        public string Category { get; set; }    

        public int SKU { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public float Price { get; set; }

        public float Discount { get; set; }
    }
}
