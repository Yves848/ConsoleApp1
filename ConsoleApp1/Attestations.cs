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
    
    public partial class Attestations
    {
        public int AttestID { get; set; }
        public int PatIdCPCL { get; set; }
        public int ArtID { get; set; }
        public string CNKNr { get; set; }
        public string AttestationType { get; set; }
        public string AttestationNr { get; set; }
        public Nullable<System.DateTime> DateActiveStart { get; set; }
        public Nullable<System.DateTime> DateActiveEnd { get; set; }
        public string ArtReimbCatCode { get; set; }
        public int AttestationQty { get; set; }
        public Nullable<int> GreenockID { get; set; }
        public string ReimbExcptCode { get; set; }
    }
}
