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
    
    public partial class CST
    {
        public int CST_ID { get; set; }
        public int Sub_ID { get; set; }
        public int Staff_ID { get; set; }
        public int Class_ID { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Subject Subject { get; set; }
    }
}