using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
   public class FurnitureFullDto
    {
        public furnitureDto Furniture { get; set; }
        public List<ColorForFurnitureDto> colors { get; set; }
        
    }
}
