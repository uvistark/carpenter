using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
using Dal;
namespace Bl_.convertion
{
    public class FactoryConvertion
    {
        //המרה מDB
        public static factoryDto ConvertToDto(Factory f)
        {
           factoryDto newFactoryConvertion=new factoryDto();
            newFactoryConvertion.FactoriesAddress = f.FactoriesAddress;
            newFactoryConvertion.FactoriesId = f.FactoriesId;
            newFactoryConvertion.FactoriesName = f.FactoriesName;
            newFactoryConvertion.FactoriesNumber = f.FactoriesNumber;
            return newFactoryConvertion;
        }
        //המרה לDB
        public static Factory ConvertToFactory(factoryDto f)
        {
            Factory newFactoryConvertion = new Factory();
            newFactoryConvertion.FactoriesAddress = f.FactoriesAddress;
            newFactoryConvertion.FactoriesId = f.FactoriesId;
            newFactoryConvertion.FactoriesName = f.FactoriesName;
            newFactoryConvertion.FactoriesNumber = f.FactoriesNumber;
            return newFactoryConvertion;
        }
    }
}
