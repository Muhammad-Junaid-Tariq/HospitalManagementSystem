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
    
    public partial class Room
    {
        public Room()
        {
            this.IndoorPatients = new HashSet<IndoorPatient>();
        }
    
        public int room_id { get; set; }
        public int totalbeds { get; set; }
        public int availbeds { get; set; }
        public Nullable<int> nurse_id { get; set; }
    
        public virtual ICollection<IndoorPatient> IndoorPatients { get; set; }
        public virtual Nurse Nurse { get; set; }
    }
}