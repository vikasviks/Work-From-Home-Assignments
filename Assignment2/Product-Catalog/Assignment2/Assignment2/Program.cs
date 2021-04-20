using Assignment2.Entities;
using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Select one the Options");
            Console.WriteLine("1. Category");
            Console.WriteLine("2. Product");
            Console.WriteLine("3. Exit The App!");

            char ch = Convert.ToChar(Console.ReadLine());

            switch(ch)
            {
                case '1':
                    CategoryOperation.CategoryOperationMenu();
                    break;
                case '2':
                    ProductOperation.ProductOperationMenu();
                    break;
                case '3':
                    return;
                default:
                    Console.WriteLine("Invalid option Selected");
                    break;
            }
        }
    }
}
