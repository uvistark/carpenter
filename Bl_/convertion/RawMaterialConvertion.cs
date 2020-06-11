using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;
namespace Bl_.convertion
{
    public class RawMaterialConvertion
    {
        //המרה מDB
        public static rawMaterialDto RawMaterialConvertionToDto(RawMaterial r)
        {
            rawMaterialDto newRawMaterialConvertoin=new rawMaterialDto();
            newRawMaterialConvertoin.RawMaterialName = r.RawMaterialName;
            newRawMaterialConvertoin.RawMaterialsId = r.RawMaterialsId;
            return newRawMaterialConvertoin;
        }
        //המרה לDB
        public static RawMaterial ConvertionToRawMaterial(RawMaterial r)
        {
            RawMaterial newRawMaterialConvertoin = new RawMaterial();
            newRawMaterialConvertoin.RawMaterialName = r.RawMaterialName;
            newRawMaterialConvertoin.RawMaterialsId = r.RawMaterialsId;
            return newRawMaterialConvertoin;
        }
    }
}
