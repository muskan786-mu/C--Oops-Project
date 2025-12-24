using System;
using System.Collections.Generic;
using System.Text;

namespace QuickKartBL
{
    public class ProductInventory
    {
        int inventoryId;
        int quantityHand;

        public ProductInventory(int inventoryId,int quantityInHand)
        {
          this.inventoryId = inventoryId;
          this.quantityHand = quantityInHand;
        }
    }
}
