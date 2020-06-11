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
    class FactoryService
    {
        //שליפת רשימת כל המפעלים
        public static List<factoryDto> getAllFactories()
        {

            using (ProjectZUEntities db = new ProjectZUEntities())
            {
                List<factoryDto> allFactories = new List<factoryDto>();
                db.Factories.ToList().ForEach(x =>
                {
                    allFactories.Add(convertion.FactoryConvertion.ConvertToDto(x));
                });
                return allFactories;
            }
        }
        //הוספת מפעל חדש
        public static void setFactory(factoryDto newFactory)
        {
            using (ProjectZUEntities db = new ProjectZUEntities())
            {
                db.Factories.Add(convertion.FactoryConvertion.ConvertToFactory(newFactory));
                db.SaveChanges();
            }
        }
    }
}
