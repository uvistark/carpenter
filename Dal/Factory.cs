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
    
    public partial class Factory
    {
        public int FactoriesId { get; set; }
        public string FactoriesName { get; set; }
        public string FactoriesAddress { get; set; }
        public string FactoriesNumber { get; set; }
        public Nullable<int> PriceOfFreightFactories { get; set; }
        public int TypesOfServiceId { get; set; }
    
        public virtual TypesOfService TypesOfService { get; set; }
    }
}
