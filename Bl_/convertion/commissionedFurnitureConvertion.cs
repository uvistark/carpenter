using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
using Dal;
     
namespace Bl_.convertion
{
    class commissionedFurnitureConvertion
    {
        //המרה מDB 
        public static commissionedFurnitureDto ConvertToDto(CommissionedFurniture co)
        {
            commissionedFurnitureDto newCommissionedFurnitureConvertion = new commissionedFurnitureDto();
            newCommissionedFurnitureConvertion.AmountCommissionedFurnitures = co.AmountCommissionedFurnitures;
            newCommissionedFurnitureConvertion.ColorsId = co.ColorsId;
            newCommissionedFurnitureConvertion.CommissionedFurnituresId = co.CommissionedFurnituresId;
            newCommissionedFurnitureConvertion.DepthCommissionedFurnitures = co.DepthCommissionedFurnitures;
            newCommissionedFurnitureConvertion.FurnitureId = co.FurnitureId;
            newCommissionedFurnitureConvertion.HeightCommissionedFurnitures = co.HeightCommissionedFurnitures;
            newCommissionedFurnitureConvertion.OrdersId = co.OrdersId;
            newCommissionedFurnitureConvertion.RawMaterialsId = co.RawMaterialsId;
            newCommissionedFurnitureConvertion.WidthCommissionedFurnitures = co.WidthCommissionedFurnitures;
            return newCommissionedFurnitureConvertion;
        }
        //המרה לDB
        public static CommissionedFurniture ConvertToCustomer(commissionedFurnitureDto co)
        {
            CommissionedFurniture newCommissionedFurnitureConvertion = new CommissionedFurniture();
            newCommissionedFurnitureConvertion.AmountCommissionedFurnitures = co.AmountCommissionedFurnitures;
            newCommissionedFurnitureConvertion.ColorsId = co.ColorsId;
            newCommissionedFurnitureConvertion.CommissionedFurnituresId = co.CommissionedFurnituresId;
            newCommissionedFurnitureConvertion.DepthCommissionedFurnitures = co.DepthCommissionedFurnitures;
            newCommissionedFurnitureConvertion.FurnitureId = co.FurnitureId;
            newCommissionedFurnitureConvertion.HeightCommissionedFurnitures = co.HeightCommissionedFurnitures;
            newCommissionedFurnitureConvertion.OrdersId = co.OrdersId;
            newCommissionedFurnitureConvertion.RawMaterialsId = co.RawMaterialsId;
            newCommissionedFurnitureConvertion.WidthCommissionedFurnitures = co.WidthCommissionedFurnitures;
            return newCommissionedFurnitureConvertion;
        }
    }
}
