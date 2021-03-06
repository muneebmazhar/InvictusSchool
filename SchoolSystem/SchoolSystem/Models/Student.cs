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
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.Attendences = new HashSet<Attendence>();
            this.Results = new HashSet<Result>();
        }
    
        public int Stud_ID { get; set; }
        public string Stud_Name { get; set; }
        public int Roll_No { get; set; }
        public bool Gender { get; set; }
        public int Phone_no { get; set; }
        public int Class_ID { get; set; }
        public int Section_ID { get; set; }
        public string Address { get; set; }
        public System.DateTime DOB { get; set; }
        public byte[] Image { get; set; }
        public Nullable<bool> Fee_Status { get; set; }
        public string Password { get; set; }
        public Nullable<int> Father_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendence> Attendences { get; set; }
        public virtual Class Class { get; set; }
        public virtual Parent Parent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Result> Results { get; set; }
        public virtual Section Section { get; set; }
    }
}
