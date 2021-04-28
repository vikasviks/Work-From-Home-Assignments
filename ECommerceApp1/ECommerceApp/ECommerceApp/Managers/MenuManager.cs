using ECommerceApp.Auth;
using ECommerceApp.Database;
using ECommerceApp.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.Managers
{

    public class MenuManager : User
    {
        string _menuType;

        public MenuManager()
        {
            this._menuType = type;
        }

        public bool CreateMenu()
        {// check the menuType and invoke the menu draw accordingly

            if (AuthManager.type == 1)
            {    
                InventoryMenu imenu = new InventoryMenu();
                imenu.DrawMenu();    
            }
            else if(AuthManager.type == 2)
            {
                Console.WriteLine("customer Menu");
            }
            return true;
        }
    }
}
