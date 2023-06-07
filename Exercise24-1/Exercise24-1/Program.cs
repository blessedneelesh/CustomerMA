using CustomerMAData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise24_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();
            Console.WriteLine("hello");
          
            Console.ReadLine();
        }

        public static void Menu()
        {
            CustomerController ctlr = new CustomerController();
            int opt;

            Console.Write("\n\n");
            Console.Write("Welcome to car company db:\n");
            Console.Write("------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("\nHere are the options :\n");
            Console.Write("1-View.\n2-Insert.\n3-Delete.\n4-Update.\n5-Exit.\n");
            Console.Write("\nInput your choice :");
            opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    ctlr.GetCustomers();
                    break;

                case 2:
                   ctlr.AddCustomer();
                    break;

                case 3:
                   ctlr.DeleteCustomer();
                    break;

                case 4:
                    ctlr.GetCustomerById();
                    break;

                case 5:
                    ctlr.UpdateCustomer();
                    break;

                case 6:
                    break;

                default:
                    Console.Write("Input correct option\n");
                    break;
            }
        }
    }
}
