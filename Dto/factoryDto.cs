using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
   public class factoryDto
    {
        public int FactoriesId { get; set; }
        public string FactoriesName { get; set; }
        public string FactoriesAddress { get; set; }
        public string FactoriesNumber { get; set; }
        public Nullable<int> PriceOfFreightFactories { get; set; }
        public int TypesOfServiceId { get; set; }
        //public virtual TypesOfService TypesOfService { get; set; }
       
    }
}
