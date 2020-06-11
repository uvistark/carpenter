using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;
namespace Bl_.services
{
    class ColorServise
    {
        // לקבלת רשימת הצבעים שיש לאתר
        public static void GetColors()
        {
            using (ProjectZUEntities db = new ProjectZUEntities())
            {
                //////החזרת רשימה get
                List<colorDto> colors = new List<colorDto>();
                db.colors.ToList().ForEach(x =>
                {
                    colors.Add(convertion.ColorConvertion.convertToDto(x));
                });
            }
        }
    }
}
