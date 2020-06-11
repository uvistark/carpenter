using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;
namespace Bl_.convertion
{
    public class OrderConvertion
    {
        //המרה מDB
        public static orderDto OrderConvertionToDto(Order o)
        {
            orderDto newOrderConvertion = new orderDto();
            newOrderConvertion.CustomersId = o.CustomersId;
            newOrderConvertion.kindOPayment = o.kindOPayment;
            newOrderConvertion.OrdersId = o.OrdersId;
            return newOrderConvertion;
        }
        //המרה לDB
        public static Order ConvertionToOrder(Order o)
        {
            Order newOrderConvertion = new Order();
            newOrderConvertion.CustomersId = o.CustomersId;
            newOrderConvertion.kindOPayment = o.kindOPayment;
            newOrderConvertion.OrdersId = o.OrdersId;
            return newOrderConvertion;
        }
    }
}
