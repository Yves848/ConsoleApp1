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
    
    public partial class TaskGroupLabels
    {
        public string GroupType { get; set; }
        public string LangCode { get; set; }
        public string GroupTypeLabel { get; set; }
    
        public virtual TaskGroupTypes TaskGroupTypes { get; set; }
    }
}
