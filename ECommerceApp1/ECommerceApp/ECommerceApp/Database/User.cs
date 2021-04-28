using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.Database
{
    public class User
    {
        public string LoginName { get; private set; }
        public string PassWord { get; private set; }
        public string type;

        public User()
        {
            this.LoginName = "vikas";
            this.PassWord = "vikas";
        }
    }

    
}
