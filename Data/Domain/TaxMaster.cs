using System.ComponentModel.DataAnnotations;

namespace CognisunPractical.Data.Domain
{
    public class TaxMaster
    {
        [Required]
        public int ID { get; set; }

        public int TaxValue { get; set; }

        public string Category { get; set; }
    }
}
