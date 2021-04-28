using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.Database
{
    public class Inventory
    {
        public long Code { get; private set; }
        public string ProductCode { get; private set; }
        public int Quantity { get; private set; }

        public Inventory(long code, int quantity)
        {
            this.Code = code;
            this.Quantity = quantity;

        }
    }
}
