using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace CognisunPractical.Models.Order
{
    public class AddOrderViewModel
    {

        public int Id { get; set; }

        public string? Category { get; set; }

        public string? ProductName { get; set; }

        public int SKU { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public double Discount { get; set; }

        public double NetPrice { get; set; }


        public double Tax { get; set; }

        public double Quantity { get; set; }

        public string ShippingType { get; set; }

        public double ShippingCharges { get; set; }


        public double TotalAmount { get; set; }


        public bool ReceiveStatusUpdate { get; set; }

        public bool SigantureRequired { get; set; }

        public DateTime EstimatedDelivery { get; set; }


        public string CustomerName { get; set; }


        public DateTime DateOFBirth { get; set; }


        public string PhoneNumber { get; set; }


    }
}
