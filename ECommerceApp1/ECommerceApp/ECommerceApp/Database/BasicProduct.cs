using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.Database
{
    public class BasicProduct
    {
        public long Code { get; private set; }
        public string Name { get; private set; }
        public string Manufacturer { get; private set; }
        public string ManufacturingDate { get; private set; }
        public string ExpiryDate { get; private set; }
        public decimal Amount { get; private set; }


        public BasicProduct(long code, string name, string manufacturer, string mdate, string edate ,decimal amount)
        {
            this.Code = code;
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.ManufacturingDate = mdate;
            this.ExpiryDate = edate;
            this.Amount = amount;
        }

    }

}

