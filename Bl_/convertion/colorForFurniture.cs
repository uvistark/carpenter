using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
using Dal;
namespace Bl_.convertion
{

   public class colorForFurnitureC
    {
        //המרה מDB
        public static ColorForFurnitureDto ConvertToDto(ColorForFurniture c)
        {
            ColorForFurnitureDto newColorForFurniture = new ColorForFurnitureDto();
            newColorForFurniture.ColorForFurnitureId = c.ColorForFurnitureId;
            newColorForFurniture.ColorsId = c.ColorsId;
            return newColorForFurniture;
        }
        //המרה לDB
        public static ColorForFurniture ConvertToColorForFurnitur(ColorForFurnitureDto c)
        {

            ColorForFurniture newColorForFurniture = new ColorForFurniture();
            newColorForFurniture.ColorForFurnitureId = c.ColorForFurnitureId;
            newColorForFurniture.ColorsId = c.ColorsId;
            return newColorForFurniture;
        }
        public static List<ColorForFurnitureDto> convertToListDto(List<ColorForFurniture> c)
        {
            List<ColorForFurnitureDto> newColor = new List<ColorForFurnitureDto>();
            c.ForEach(x =>
            {
                newColor.Add(ConvertToDto(x));
            });
            return newColor;
        }
        public static List<ColorForFurniture> convertToListColorFun(List<ColorForFurnitureDto> c)
        {
            List<ColorForFurniture> newColor = new List<ColorForFurniture>();
            c.ForEach(x =>
            {
                newColor.Add(ConvertToColorForFurnitur(x));
            });
            return newColor;
        }
    }
}
