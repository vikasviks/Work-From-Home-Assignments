using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerceApp.Database
{
    public class RepoDb<t>
    {

        List<User> _users;
        public static List<BasicProduct> _products = new List<BasicProduct>();
        List<Inventory> _inventory;


        public bool Add<T>(T record)
        {

            if (record.GetType() == typeof(BasicProduct))
            {
                
                BasicProduct obj1 = (BasicProduct)Convert.ChangeType(record, typeof(BasicProduct));
                _products.Add(obj1);
                Console.WriteLine("\t\t\tProducts Added!");
                Console.WriteLine("Code\t\tName\t\tManufacturer\t\tManufacturingDate\t\tExpiryDate\t\tAmount");
                Console.WriteLine(" ");
                foreach (var item in _products)
                {
                    Console.WriteLine(item.Code + "\t\t" + item.Name + "\t\t" + item.Manufacturer + "\t\t\t" + item.ManufacturingDate + "\t\t\t" + item.ExpiryDate + "\t\t\t" + item.Amount);
                }  
            }

            return true;
       }

        public bool Remove<T>(long productCode)
        {
            var res = _products.Single(item => item.Code == productCode);
            _products.Remove(res);
            Console.WriteLine(_products.Count());
            return true;
        }

        public bool Get<T>(long productCode)
        {
            
                Console.WriteLine("\t\t\tProducts");
                Console.WriteLine("Code\t\tName\t\tManufacturer\t\tManufacturingDate\t\tExpiryDate\t\tAmount");
                Console.WriteLine(" ");
                var producttoremove = _products.Single(r => r.Code == productCode);     
                Console.WriteLine(producttoremove.Code + "\t\t" + producttoremove.Name + "\t\t" + producttoremove.Manufacturer + "\t\t\t" + producttoremove.ManufacturingDate + "\t\t\t" + producttoremove.ExpiryDate + "\t\t\t" + producttoremove.Amount);
                
            return true;
        }

        public List<BaseRecordType> GetAll(Type recordType)
        {
            List<BaseRecordType> baseRecType = null;
            return baseRecType;
        }
    }
}
