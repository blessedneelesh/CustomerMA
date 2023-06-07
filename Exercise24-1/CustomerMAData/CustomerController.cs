using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMAData
{
   public class CustomerController
    {
        public void GetCustomers()
        {
            var customer = CustomerOperation.GetCustomer();
            for (int i = 0; i < customer.Count; i++)
            {
                Console.WriteLine(customer[i].CustomerId+ " -- " + customer[i].Name + " -- " + customer[i].Address + " -- " + 
                    customer[i].City + " -- " + customer[i].StateCode + " -- " + customer[i].ZipCode);
            }
        }

        public void AddCustomer()
        {
            string name, address, city,stateCode, zip;
            Console.WriteLine("Please enter name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter address");
            address = Console.ReadLine();
            Console.WriteLine("Please enter city");
            city = Console.ReadLine();
            Console.WriteLine("Please enter state code");
            stateCode = Console.ReadLine();
            Console.WriteLine("Please enter zip");
            zip = Console.ReadLine();

            Customer newCust = new Customer
            {
                Name = name,
                Address = address,
                City
              = city,
                StateCode = stateCode,
                ZipCode = zip
            };

            CustomerOperation.AddCustomer(newCust);
        }

        public void DeleteCustomer()
        {
            int deleteId;
            Console.WriteLine("Please enter customer id you want to delete.");
            deleteId = Convert.ToInt32(Console.ReadLine());
            CustomerOperation.DeleteCustomer(deleteId);
        }

        public void GetCustomerById()
        {
            int id;
            Console.WriteLine("Please enter a id of customer you want to retrive?");
            id = Convert.ToInt32(Console.ReadLine());
            CustomerVo retrieveCust=CustomerOperation.GetCustomerById(id);
            
                Console.WriteLine(retrieveCust.CustomerId + " -- " + retrieveCust.Name + " -- " + retrieveCust.Address + " -- " +
                    retrieveCust.City + " -- " + retrieveCust.StateCode + " -- " + retrieveCust.ZipCode);
            
        }

        public void UpdateCustomer()
        {
            int id;
            Console.WriteLine("Please enter a id of customer you want to update");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CustomerOperation.GetCustomerById(id));

            string name, address, city, stateCode, zip;
            Console.WriteLine("Please enter name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter address");
            address = Console.ReadLine();
            Console.WriteLine("Please enter city");
            city = Console.ReadLine();
            Console.WriteLine("Please enter state code");
            stateCode = Console.ReadLine();
            Console.WriteLine("Please enter zip");
            zip = Console.ReadLine();

            Customer newCust = new Customer
            {
                Name = name,
                Address = address,
                City
              = city,
                StateCode = stateCode,
                ZipCode = zip
            };

            CustomerOperation.UpdateCustomer(id, newCust);
        }
    }
}
