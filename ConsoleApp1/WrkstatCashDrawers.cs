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
    
    public partial class WrkstatCashDrawers
    {
        public int WrkstatDeviceID { get; set; }
        public string PrinterPort { get; set; }
    
        public virtual WorkstationDevices WorkstationDevices { get; set; }
    }
}
