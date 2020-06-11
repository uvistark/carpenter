using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
using Dal;
using System.Collections;
namespace Bl_.services
{
    class TypeOfServiceService
    {
        //לקבלת סוגי השרות של מפעל מסוים
        public static List<typeOfServiceDto> getTypeOfService(factoryDto factory)
        {
            using (ProjectZUEntities db = new ProjectZUEntities())
            {
                List<typeOfServiceDto> typeServiseOfFactory = new List<typeOfServiceDto>();
                List<TypesOfService>typeOfService= db.TypesOfServices.ToList();
                foreach (var item in typeOfService)
                {
                    if (factory.TypesOfServiceId == item.TypesOfServiceId)
                        typeServiseOfFactory.Add(convertion.TypeOsServiceConvertion.ConvertionToDto(item));
                }
                return typeServiseOfFactory;
            }
        }
    }
}
