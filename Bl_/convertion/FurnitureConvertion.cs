using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
using Dal;
namespace Bl_.convertion
{
    public class FurnitureConvertion
    {
        //המרה מDB
        public static furnitureDto FurnitureConvertionToDto(Furniture f)
        {
            furnitureDto newFurnitureConvertion=new furnitureDto();
            newFurnitureConvertion.DepthFurniture = f.DepthFurniture;
            newFurnitureConvertion.FurnitureAddDoor = f.FurnitureAddDoor;
            newFurnitureConvertion.FurnitureAddShelf = f.FurnitureAddShelf;
            newFurnitureConvertion.FurnitureId = f.FurnitureId;
            newFurnitureConvertion.FurnitureInstructions = f.FurnitureInstructions;
            newFurnitureConvertion.FurnitureName = f.FurnitureName;
            newFurnitureConvertion.FurniturePreparationTime = f.FurniturePreparationTime;
            newFurnitureConvertion.FurnitureWarranty = f.FurnitureWarranty;
            return newFurnitureConvertion;
        }
        //המרה לDB
        public static Furniture ConverToFurniture(furnitureDto f)
        {
            Furniture newFurnitureConvertion = new Furniture();
            newFurnitureConvertion.DepthFurniture = f.DepthFurniture;
            newFurnitureConvertion.FurnitureAddDoor = f.FurnitureAddDoor;
            newFurnitureConvertion.FurnitureAddShelf = f.FurnitureAddShelf;
            newFurnitureConvertion.FurnitureId = f.FurnitureId;
            newFurnitureConvertion.FurnitureInstructions = f.FurnitureInstructions;
            newFurnitureConvertion.FurnitureName = f.FurnitureName;
            newFurnitureConvertion.FurniturePreparationTime = f.FurniturePreparationTime;
            newFurnitureConvertion.FurnitureWarranty = f.FurnitureWarranty;
            return newFurnitureConvertion;
        }

    }
}
