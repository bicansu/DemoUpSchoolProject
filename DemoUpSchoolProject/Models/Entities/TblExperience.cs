//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoUpSchoolProject.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblExperience
    {
        public int ExperienceID { get; set; }
        public string CompanyName { get; set; }
        public string JobDescription { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> LeaveDate { get; set; }
    }
}