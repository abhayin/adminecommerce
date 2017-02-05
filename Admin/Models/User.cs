using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string ShippingFirstName { get; set; }
        public string ShippingLastName { get; set; }
        public string ShippingAddressLine1 { get; set; }
        public string ShippingAddressLine2 { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingCountry { get; set; }
        public int ShippingPostalCode { get; set; }
        public string BillingFirstName { get; set; }
        public string BillingLastName { get; set; }
        public string BillingAddressLine1 { get; set; }
        public string BillingAddressLine2 { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingCountry { get; set; }
        public int BillingPostalCode { get; set; }
        public bool IsDeleted { get; set; }
    }
}