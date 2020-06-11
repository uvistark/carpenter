using Dal;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl_.convertion
{
    public class FurnitureFullconvertion
    {
        public static Furniture fullFuntiorConvertionToDto(FurnitureFullDto o)
        {
            Furniture furniture = new Furniture();
            furniture = convertion.FurnitureConvertion.ConverToFurniture(o.Furniture);
            furniture.ColorForFurnitures = convertion.colorForFurnitureC.convertToListColorFun(o.colors);
            return furniture;
        }
    }
}
