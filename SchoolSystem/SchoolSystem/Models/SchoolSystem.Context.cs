﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SchoolSystemsEntities : DbContext
    {
        public SchoolSystemsEntities()
            : base("name=SchoolSystemsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Attendence> Attendences { get; set; }
        public virtual DbSet<Cl_Sec> Cl_Sec { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<CST> CSTs { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Exam_Schedule> Exam_Schedule { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Weather> Weathers { get; set; }
    }
}