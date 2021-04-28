using ECommerceApp.Auth;
using ECommerceApp.Database;
using ECommerceApp.Managers;
using System;

namespace ECommerceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to E-Commerce Application*****\n");
            AuthManager auth = new AuthManager();
            AuthManager.AcceptLoginCreds();
            
            
            
        }
    }
}
