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
    
    public partial class reservations
    {
        public reservations()
        {
            this.schedules = new HashSet<schedules>();
        }
    
        public int ID { get; set; }
        public int CREATOR_ID { get; set; }
        public Nullable<int> TRAINING_ID { get; set; }
        public int FACILITY_ID { get; set; }
        public Nullable<int> EVENT_ID { get; set; }
        public Nullable<int> ACCEPTER_ID { get; set; }
        public Nullable<bool> ACCEPTED { get; set; }
        public Nullable<System.DateTime> START { get; set; }
        public Nullable<System.DateTime> END { get; set; }
    
        public virtual admins admins { get; set; }
        public virtual employees employees { get; set; }
        public virtual events events { get; set; }
        public virtual facilities facilities { get; set; }
        public virtual trainings trainings { get; set; }
        public virtual ICollection<schedules> schedules { get; set; }
    }
}
