using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using CustomerMAData;
using System.Web.Http.Cors;


namespace CustomerAPI.Controllers
{
    public class CustomersController : ApiController
    {
        //static customer cust = new customer();

        // GET api/values
        public IEnumerable<CustomerVo> Get()
        {
            
            //return new string[] { "value1", "value2" };
            /*            List<Customer> receivedCust = CustomerOperation.GetCustomer().ToList();
                        Customer displayCust=new Customer({ CustomerId=receivedCust});*/
            return CustomerOperation.GetCustomer();

        }

        // GET api/values/5
        public CustomerVo Get(int id)
        {
            return CustomerOperation.GetCustomerById(id);
            
        }

        // POST api/values
        public Customer Post([FromBody] Customer value)
        {
            CustomerOperation.AddCustomer(value);
            return value;
           // return 
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
