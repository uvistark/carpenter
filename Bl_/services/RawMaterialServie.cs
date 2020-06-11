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
    class RawMaterialServie
    {//לשאול
        //פונקציה שמחזירה את שמות החומרי גלם מהם עשוי הרהיט
        public static List<rawMaterialDto> GetNameMateriaslOfFurniture()
        {
            using (ProjectZUEntities db = new ProjectZUEntities())
            {
                List<rawMaterialDto> rawmaterial = new List<rawMaterialDto>();
                List<RawMaterial> rawmaterialDB = db.RawMaterials.ToList();
                List<Furniture> furnituredB = db.Furnitures.ToList();
                foreach (var item in rawmaterialDB)
                {
                    foreach (var item2 in furnituredB)
                    {
                        if (item.RawMaterialsId == item2.RawMaterialsId)
                            rawmaterial.Add(convertion.RawMaterialConvertion.RawMaterialConvertionToDto(item));
                    }
                }
                return rawmaterial;
            }

        }

    }
}
