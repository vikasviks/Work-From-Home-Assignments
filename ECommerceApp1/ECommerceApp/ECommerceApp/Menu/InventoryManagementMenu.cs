using ECommerceApp.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.Menu
{
    internal class InventoryManagementMenu 
    {
        int _productId;
        string _displayName;
        string _qtyAvailable;
        string _productInputCode;

        internal bool DrawSubMenuItem()
        {
            return true;
        }
        internal InventoryManagementMenu(int productId, string displayName, string qtyAvailable, string productInputCode)
        {
            this._productId = productId;
            this._displayName = displayName;
            this._qtyAvailable = qtyAvailable;
            this._productInputCode = productInputCode;
        }
    }


    internal class InventorySubMenu
    {
        List<InventoryManagementMenu> _subMenuItems;

        internal bool DrawSubMenu()
        {
            InventoryManagementMenu menu = new InventoryManagementMenu(1, "abc", "34", "qwe");
            return true;
        }
        internal InventorySubMenu()
        {
            
            _subMenuItems = new List<InventoryManagementMenu>();
        }
    }

   

    internal class InventoryMenu
    {

        List<InventorySubMenu> _subMenus;
        internal bool DrawMenu()
        {
            
           InventorySubMenu isubmenu = new InventorySubMenu();
            string s;
            do
            {



                RepoDb<BasicProduct> db = new RepoDb<BasicProduct>();
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Search Product");
                Console.WriteLine("3. Delete Product");
                Console.WriteLine("4. Update Product");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {

                    Console.WriteLine("Enter product code(integer)");
                    long code = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter product name(string)");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter product Manufacturer name(string)");
                    string man = Console.ReadLine();
                    Console.WriteLine("Enter product Manufacturing date");
                    string mdate = Console.ReadLine();
                    Console.WriteLine("Enter product Expiry date");
                    string edate = Console.ReadLine();
                    Console.WriteLine("Enter product Amount(integer)");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                    BasicProduct product = new BasicProduct(code, name, man, mdate, edate, amount);

                    db.Add<BasicProduct>(product);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter product code(integer)");
                    long code = Convert.ToInt32(Console.ReadLine());
                    db.Get<BasicProduct>(code);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Enter ID to remove product");
                    long id = Convert.ToInt32(Console.ReadLine());
                    db.Remove<BasicProduct>(id);
                }
                Console.WriteLine("Want to perform another operation ?Then type yes");
                s = Console.ReadLine();
            } while (s == "yes");
            return true;

        }
        internal InventoryMenu()
        {
            _subMenus = new List<InventorySubMenu>();
        }
    }
}
