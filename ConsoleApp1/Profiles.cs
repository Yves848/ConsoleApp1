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
    
    public partial class Profiles
    {
        public string ProfileType { get; set; }
        public int SecurityLevel { get; set; }
        public int RoleID { get; set; }
        public byte[] CRC { get; set; }
        public Nullable<System.DateTime> DateLastChange { get; set; }
        public Nullable<int> UIDLastChange { get; set; }
    
        public virtual Roles Roles { get; set; }
        public virtual ProfileTypes ProfileTypes { get; set; }
    }
}
