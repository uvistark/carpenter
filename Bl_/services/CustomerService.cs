using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;
namespace Bl_
{
    public class CustomerService
    {
        public static void name()
        {
            //using
        }
        //הוספת משתמש
        public static void AddNewcustomer(CustomerDto customerDto)
        {
            using (ProjectZUEntities db = new ProjectZUEntities())
            {
                //הוספת חדש post
                db.Customers.Add(convertion.customerConvertion.ConvertToCustomer(customerDto));
                db.SaveChanges();
            }
        }

        //לקבלת משתמש שחיפשנו 
        public static CustomerDto GetUser(string email, string password, CustomerDto customerDto)//מקבך DTO
        {
            //int colorId,
            //להוסיף סיסמא 
            using (ProjectZUEntities db = new ProjectZUEntities())
            {
                //חיפוש מסוים get(parametr)
                 Customer customerFind = new Customer();
                customerFind = db.Customers.ToList().FirstOrDefault(x => x.CustomersEmail == email && x.CustomersId == password);
                return convertion.customerConvertion.ConvertToDto(customerFind);
            }
        }
    }
}
