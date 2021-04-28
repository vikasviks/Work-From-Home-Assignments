using ECommerceApp.Database;
using ECommerceApp.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.Auth
{
    public class AuthManager
    {

        public static string username;
        public static string password;
        public static int type;

        public static bool AcceptLoginCreds()
        {
            Console.WriteLine(" Enter Your Username");
            username = Console.ReadLine();
            Console.WriteLine(" Enter Your Password");
            password = Console.ReadLine();
           
            if(ValidateUser())
            {
                Console.WriteLine("1. Login as a Manager");
                Console.WriteLine("2. Login as a Customer");
                type = Convert.ToInt32(Console.ReadLine());

                    MenuManager menu = new MenuManager();
                    menu.CreateMenu();
                    return true;
                
            }
            return false;
        }

        private static bool ValidateUser()
        {
            User user = new User();
            
                if(user.LoginName==username && user.PassWord==password )
                {
                    return true;
                }
            

            return false;
        }
    }
}
