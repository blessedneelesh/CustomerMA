using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMAData
{
    public class CustomerOperation
    {
        static CustomerMAEntities dbContext = new CustomerMAEntities();
        public static List<CustomerVo> GetCustomer()
        {
            //var lst = (from n in dbContext.customers.Include("zip1") select n).ToList();
            var lst = (from n in dbContext.Customers select new CustomerVo { CustomerId=n.CustomerId, Name=n.Name, Address= n.Address,
                City = n.City, StateCode= n.StateCode, ZipCode= n.ZipCode }).ToList(); // query against conceptual model. 
            // you are using customers property of the object context as the data source for the query.
            // this property returns a collection of customer objects.

            // since Customer entity in mapped to Customers Table in the CarCompany database, this expression query
            // retrieves data from the table.
            return lst;
        }

        public static void AddCustomer(Customer newCust)
        {
            dbContext.Customers.Add(newCust);
            dbContext.SaveChanges();
        }

        public static void DeleteCustomer(int deleteCustomer)
        {
            var selectedCust = (from customer in dbContext.Customers
                                where customer.CustomerId == deleteCustomer
                                select customer).Single();

            dbContext.Customers.Remove(selectedCust);
            dbContext.SaveChanges();
        }

        public static CustomerVo GetCustomerById(int id)
        {
            var lst = (from n in dbContext.Customers where n.CustomerId == id
                       select new CustomerVo
                       {
                           CustomerId = n.CustomerId,
                           Name = n.Name,
                           Address = n.Address,
                           City = n.City,
                           StateCode = n.StateCode,
                           ZipCode = n.ZipCode
                       }).SingleOrDefault();
            return lst;
        }

        public static void UpdateCustomer(int id, Customer cust)
        {
            CustomerVo selectedCust = GetCustomerById(id);
            selectedCust.Name = cust.Name;
            selectedCust.Address = cust.Address;
            selectedCust.City = cust.City;
            selectedCust.StateCode = cust.StateCode;
            selectedCust.ZipCode = cust.ZipCode;
            dbContext.SaveChanges();
        }
    }
}
