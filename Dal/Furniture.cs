//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Furniture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Furniture()
        {
            this.ColorForFurnitures = new HashSet<ColorForFurniture>();
            this.CommissionedFurnitures = new HashSet<CommissionedFurniture>();
        }
    
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
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ColorForFurniture> ColorForFurnitures { get; set; }
        public virtual RawMaterial RawMaterial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommissionedFurniture> CommissionedFurnitures { get; set; }
    }
}
