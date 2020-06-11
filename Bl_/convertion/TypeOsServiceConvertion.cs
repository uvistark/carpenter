using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;
namespace Bl_.convertion
{
    public class TypeOsServiceConvertion
    {
        //המרה מDB
        public static typeOfServiceDto ConvertionToDto(TypesOfService t)
        {
            typeOfServiceDto newTypeOfServiceConvertion=new typeOfServiceDto();
            newTypeOfServiceConvertion.TypesOfServiceId = t.TypesOfServiceId;
            newTypeOfServiceConvertion.TypesOfServiceName = t.TypesOfServiceName;
            return newTypeOfServiceConvertion;
        }
        //המרה לDB
        public static TypesOfService ConvertionToTypesOfService(TypesOfService t)
        {
           TypesOfService newTypeOfServiceConvertion = new  TypesOfService();
            newTypeOfServiceConvertion.TypesOfServiceId = t.TypesOfServiceId;
            newTypeOfServiceConvertion.TypesOfServiceName = t.TypesOfServiceName;
            return newTypeOfServiceConvertion;
        }
    }
}
