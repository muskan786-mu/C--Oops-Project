using System;
using System.Collections.Generic;
using System.Text;

namespace QuickKartBL
{
    public class Purchase
    {
        private DateTime dateOfPurchase;
        private string paymentType;
        private string purchaseId;
        private int quntityOrdered;
        private string shippingAddress;

        public DateTime DateOfPurchase { get; set; }
        public string PaymentType { get; set; }
        public string PurchaseId { get; set; }
        public int QuantityOrdered {  get; set; }
        public string ShippingAddress { get; set; }




        public Purchase(DateTime dateOfPurchase,string paymentType,string purchaseId,int quantityOrdered,string shippingAddress)
        {
            this.DateOfPurchase = dateOfPurchase;
            this.PaymentType = paymentType;
            this.PurchaseId = purchaseId;
            this.QuantityOrdered = quantityOrdered;
            this.ShippingAddress = shippingAddress;
        }
        public double CalculateBillAmount(double price)
        {
            double amount = quntityOrdered * price;
            return amount; 
        }
        public double CalculateBillAmount(double price,double discountPercentage)
        {
            return quntityOrdered * price * discountPercentage;
        }

    }
}
