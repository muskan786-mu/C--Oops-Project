using System;
using System.Collections.Generic;
using System.Text;

namespace QuickKartBL
{
    public class Seller
    {
        private string sellerId;
        private string sellerName;

        public string SellerId { get; set; }
        public string[] SellerLocation {  get; set; }
        public string SellerName { get
            {
                return sellerName;
            }
            set
            {
                if (Validator.IsName(value))
                     sellerName = value;
                else
                    sellerName = null;
            } }

        public Seller(string sellerId,string sellerName)
        {
            this.SellerId = sellerId;
            this.SellerName = sellerName;
        }
       
    }
}
