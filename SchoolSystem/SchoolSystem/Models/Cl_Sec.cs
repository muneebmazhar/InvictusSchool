//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cl_Sec
    {
        public int CS_ID { get; set; }
        public int Class_ID { get; set; }
        public Nullable<int> Sec_ID { get; set; }
    
        public virtual Class Class { get; set; }
    }
}
