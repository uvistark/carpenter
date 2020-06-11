using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;
namespace Bl_.convertion
{
    public class ColorConvertion
    {
        //המרה מDB
        public static colorDto convertToDto(color c)
        {
            colorDto newColor=new colorDto();
            newColor.ColorsId = c.ColorsId;
            newColor.colorsName = c.colorsName;
            return newColor;
        }
        public static List<colorDto> convertToListDto(List<color> c)
        {
            List<colorDto> newColor = new List<colorDto>();
            c.ForEach(x =>
            {
                newColor.Add(convertToDto(x));
            });
            return newColor;
        }
        public static List<color> convertToListColor(List<colorDto> c)
        {
            List<color> newColor = new List<color>();
            c.ForEach(x =>
            {
                newColor.Add(convertToColor(x));
            });
            return newColor;
        }
        //המרה לDB
        public static color convertToColor(colorDto c)
        {
            color newColor = new color();
            newColor.ColorsId = c.ColorsId;
            newColor.colorsName = c.colorsName;
            return newColor;
        }
    }
}
