//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportCenterManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class trainings
    {
        public trainings()
        {
            this.reservations = new HashSet<reservations>();
            this.services = new HashSet<services>();
            this.coaches = new HashSet<coaches>();
        }
    
        public int ID { get; set; }
        public string DESCRIPTION { get; set; }
        public string NAME { get; set; }
    
        public virtual ICollection<reservations> reservations { get; set; }
        public virtual ICollection<services> services { get; set; }
        public virtual ICollection<coaches> coaches { get; set; }
    }
}
