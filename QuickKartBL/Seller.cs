using System;
using System.Collections.Generic;
using System.Text;

namespace QuickKartBL
{
    public class Seller
    {
        private string sellerId;
        private static int sellerIdCount;
        private string sellerName;

        public string SellerId { get
            {
                return sellerId;
            } set
            {
                sellerId = value;
            }
        }
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
        public Seller()
        {

        }
        public Seller(int maxSize)
        {
            SellerLocation = new string[maxSize];
        }
        public Seller(string sellerId, string sellerName)
        {
            this.SellerId = sellerId;
            this.SellerName = sellerName;
        }
        //Addlocations method using params
        public bool AddLocations(params string[] sellerLocations)
        {
            int index = 0;
            //Find next available position
            for(int i = 0; i < sellerLocations.Length; i++ )
            {
                if (SellerLocation[i] == null)
                {
                    index = i;
                    break;
                }
            }
            if(SellerLocation.Length - index < sellerLocations.Length)
            {
                return false;
            }
            foreach(string location in sellerLocations)
            {
                SellerLocation[index++] = location;
            }
            return true;
        }
       
    }
}
