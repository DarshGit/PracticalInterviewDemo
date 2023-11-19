using System;
using System.ComponentModel.DataAnnotations;

namespace CognisunPractical.Models.Order
{
    public class AddOrderViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Product Name is required.")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "SKU is required.")]
        public int SKU { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Discount is required.")]
        [Range(0, 100, ErrorMessage = "Discount must be between 0 and 100.")]
        public double Discount { get; set; }

        [Required(ErrorMessage = "Net Price is required.")]
        public double NetPrice { get; set; }

        [Required(ErrorMessage = "Tax is required.")]
        public double Tax { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0.")]
        public double Quantity { get; set; }

        [Required(ErrorMessage = "Shipping Type is required.")]
        public string ShippingType { get; set; }

        [Required(ErrorMessage = "Shipping Charges are required.")]
        public double ShippingCharges { get; set; }

        [Required(ErrorMessage = "Total Amount is required.")]
        public double TotalAmount { get; set; }

        public bool ReceiveStatusUpdate { get; set; }

        public bool SigantureRequired { get; set; }

        [Required(ErrorMessage = "Estimated Delivery is required.")]
        [DataType(DataType.DateTime, ErrorMessage = "Invalid date format.")]
        public DateTime EstimatedDelivery { get; set; }

        [Required(ErrorMessage = "Customer Name is required.")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")]
        [DataType(DataType.Date, ErrorMessage = "Invalid date format.")]
        public DateTime DateOFBirth { get; set; }

        [Required(ErrorMessage = "Phone Number is required.")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid phone number format.")]
        public string PhoneNumber { get; set; }
    }
}
