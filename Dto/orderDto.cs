using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
   public class orderDto
    {
        public int OrdersId { get; set; }
        public string CustomersId { get; set; }
        public string kindOPayment { get; set; }
        public Nullable<int> TotalToPay { get; set; }
    }
}
