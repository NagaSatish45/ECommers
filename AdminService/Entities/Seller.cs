using System;
using System.Collections.Generic;

namespace AdminService.Entities
{
    public partial class Seller
    {
        public int SellerId { get; set; }
        public string SellerName { get; set; }
        public string KycAproval { get; set; }
    }
}
