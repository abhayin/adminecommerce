using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Models
{
    public class SocialInformation
    {
        public int SocialId { get; set; }
        public string UserId { get; set; }
        public string StoreName { get; set; }
        public string StoreTagLine { get; set; }
        public string StoreMobileNumber { get; set; }
        public string StoreEmail { get; set; }
        public string StoreAddressLine1 { get; set; }
        public string StoreAddressLine2 { get; set; }
        public string StoreCity { get; set; }
        public string StoreState { get; set; }
        public string StoreCountry { get; set; }
        public int StorePostalCode { get; set; }
        public string StoreFacebookLink { get; set; }
        public string StoreTwitterLink { get; set; }
        public string StoreInstagramLink { get; set; }
        public string Newsletter { get; set; }
        public ApplicationUser User { get; set; }
    }
}