using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
   public class commissionedFurnitureDto
    {
        public int CommissionedFurnituresId { get; set; }
        public int OrdersId { get; set; }
        public int FurnitureId { get; set; }
        public int ColorsId { get; set; }
        public int RawMaterialsId { get; set; }
        public Nullable<int> AmountCommissionedFurnitures { get; set; }
        public Nullable<int> HeightCommissionedFurnitures { get; set; }
        public Nullable<int> WidthCommissionedFurnitures { get; set; }
        public Nullable<int> DepthCommissionedFurnitures { get; set; }
        //public virtual colorDto color { get; set; }
        //public virtual furnitureDto Furniture { get; set; }
        //public virtual orderDto Order { get; set; }
        //public virtual rawMaterialDto RawMaterial { get; set; }
    }
}
