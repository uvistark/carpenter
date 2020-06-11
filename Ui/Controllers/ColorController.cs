using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bl_;
using Dto;
namespace Ui.Controllers
{
    public class ColorController : ApiController
    {
     public CustomerDto GetCustomer()
        {
            
            CustomerService.name();
        }
        [HttpPost]
        public IHttpActionResult postCustomer(CustomerDto customerDto)
        {
            if (customerDto == null)
                return BadRequest();
            if (true)
                return Ok(customerDto);//200
              // NotFound()//404
           return BadRequest();//404     
        }
    
    }

}
