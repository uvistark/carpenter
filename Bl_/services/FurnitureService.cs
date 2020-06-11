using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Bl_.services
{
    class FurnitureService
    {
        public static bool postFuniture(FurnitureFullDto furniturFul)
        {
            using (ProjectZUEntities db = new ProjectZUEntities())
            {
                // ColorForFurniture color = new ColorForFurniture();
               
                //שרשור נתונים
                db.Furnitures.Add(convertion.FurnitureFullconvertion.fullFuntiorConvertionToDto(furniturFul));
                db.SaveChanges();
                return true;
            }
        }
    }
}
