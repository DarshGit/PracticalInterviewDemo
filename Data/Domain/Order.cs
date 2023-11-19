using System.ComponentModel.DataAnnotations;

namespace CognisunPractical.Data.Domain
{
    public class Order
    {
        [Required]
        public int OrderID { get; set; }

        public string Category { get; set; }
        public string Product { get; set; }

        public string Description { get; set; }
        public int Quantity { get; set; }

        public string ShippingType { get; set; }

        public double TotalAmount { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool RecieveStatusUpdate { get; set; }
        public bool SignatureRequired { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CustomerName { get; set; }

        public string PhoneNumber { get; set; }

    }
}
