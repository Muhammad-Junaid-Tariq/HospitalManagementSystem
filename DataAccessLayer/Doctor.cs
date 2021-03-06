//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Doctor
    {
        public Doctor()
        {
            this.Patients = new HashSet<Patient>();
            this.Prescriptions = new HashSet<Prescription>();
        }
    
        public int doc_id { get; set; }
        public Nullable<int> cat_id { get; set; }
        public Nullable<int> emp_id { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual Category Category { get; set; }
    }
}
