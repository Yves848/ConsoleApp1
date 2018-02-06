//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hvts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hvts()
        {
            this.HvtNames = new HashSet<HvtNames>();
            this.HvtQtyPrices = new HashSet<HvtQtyPrices>();
        }
    
        public int ArtHvtID { get; set; }
        public string GroupingCode { get; set; }
        public string TarGroupCode { get; set; }
        public Nullable<short> IsList2 { get; set; }
        public string SupplemLabel { get; set; }
        public Nullable<int> DataUdID { get; set; }
        public Nullable<int> GreenockID { get; set; }
        public string CNKNr { get; set; }
        public Nullable<int> ArtCID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HvtNames> HvtNames { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HvtQtyPrices> HvtQtyPrices { get; set; }
    }
}
