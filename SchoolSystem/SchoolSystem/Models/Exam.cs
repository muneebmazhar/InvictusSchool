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
    
    public partial class Exam
    {
        public int Exam_ID { get; set; }
        public string Exam_Name { get; set; }
        public int Class_ID { get; set; }
        public int Exam_Sched_ID { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual Exam_Schedule Exam_Schedule { get; set; }
    }
}
