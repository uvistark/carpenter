using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
   public class furnitureDto
    {
        public int FurnitureId { get; set; }
        public string FurnitureName { get; set; }
        public string FurnitureInstructions { get; set; }
        public Nullable<int> HeightFurniture { get; set; }
        public Nullable<int> WidthFurniture { get; set; }
        public Nullable<int> DepthFurniture { get; set; }
        public int RawMaterialsId { get; set; }
        public string FurniturePreparationTime { get; set; }
        public string FurnitureWarranty { get; set; }
        public string FurnitureAddDoor { get; set; }
        public string FurnitureAddShelf { get; set; }
        
    }
}
