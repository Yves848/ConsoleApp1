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
    
    public partial class Formulas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Formulas()
        {
            this.FormulaItems = new HashSet<FormulaItems>();
            this.FormulaLabels = new HashSet<FormulaLabels>();
        }
    
        public int FormID { get; set; }
        public Nullable<decimal> FormQtd { get; set; }
        public string UnitCodePrepQtd { get; set; }
        public Nullable<short> IsApb { get; set; }
        public Nullable<decimal> Density { get; set; }
        public string FormulariumCode { get; set; }
        public string GalformCode { get; set; }
        public Nullable<int> DtQty { get; set; }
        public Nullable<int> GreenockID { get; set; }
        public string CnkNr { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormulaItems> FormulaItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormulaLabels> FormulaLabels { get; set; }
    }
}
