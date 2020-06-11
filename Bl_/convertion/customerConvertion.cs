using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;
namespace Bl_.convertion
{
    
   public class customerConvertion
    {
        //המרה מDB 
        public static CustomerDto ConvertToDto(Customer c)
        {
            CustomerDto newCustomerConvertion = new CustomerDto();
            newCustomerConvertion.CustomersAddress = c.CustomersAddress;
            newCustomerConvertion.CustomersEmail = c.CustomersEmail;
            newCustomerConvertion.CustomersId = c.CustomersId;
            newCustomerConvertion.CustomersName = c.CustomersName;
            newCustomerConvertion.CustomersPhone = c.CustomersPhone;
            return newCustomerConvertion;
        }
        //המרה לDB
        public static Customer ConvertToCustomer(CustomerDto c)
        {
            Customer newCustomerConvertion = new Customer();
            newCustomerConvertion.CustomersAddress = c.CustomersAddress;
            newCustomerConvertion.CustomersEmail = c.CustomersEmail;
            newCustomerConvertion.CustomersId = c.CustomersId;
            newCustomerConvertion.CustomersName = c.CustomersName;
            newCustomerConvertion.CustomersPhone = c.CustomersPhone;
            return newCustomerConvertion;
        }
    }
}
