using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.Menu
{
    internal class CustomerSubMenuItem
    {
        int _productId;
        string _displayName;
        string _qtyAvailable;
        string _productInputCode;

        internal bool DrawSubMenuItem()
        {
            return true;
        }
        internal CustomerSubMenuItem(int productId,string displayName,string qtyAvailable,string productInputCode)
        {
            this._productId = productId;
            this._displayName = displayName;
            this._qtyAvailable = qtyAvailable;
            this._productInputCode = productInputCode;
        }
    }
    internal class CustomerSubMenu
    {
        List<CustomerSubMenuItem> _subMenuItems;

        internal bool DrawSubMenu()
        {
            return true;
        }
        internal CustomerSubMenu()
        {
            _subMenuItems = new List<CustomerSubMenuItem>();
        }
    }

    internal class CustomerMenu
    {
        List<CustomerSubMenu> _subMenus;
        internal bool DrawMenu()
        {
                
            return true;

        }
        internal CustomerMenu()
        {
            _subMenus = new List<CustomerSubMenu>();
        }
    }
}
