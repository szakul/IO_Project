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
    
    public partial class employees
    {
        public employees()
        {
            this.admins = new HashSet<admins>();
            this.cashiers = new HashSet<cashiers>();
            this.coaches = new HashSet<coaches>();
            this.reservations = new HashSet<reservations>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public Nullable<System.DateTime> BIRTH_DATE { get; set; }
        public string PIN { get; set; }
        public string SEX { get; set; }
        public string PHONE_NR { get; set; }
        public string EMAIL { get; set; }
        public Nullable<int> ACCOUNT_ID { get; set; }
    
        public virtual accounts accounts { get; set; }
        public virtual ICollection<admins> admins { get; set; }
        public virtual ICollection<cashiers> cashiers { get; set; }
        public virtual ICollection<coaches> coaches { get; set; }
        public virtual ICollection<reservations> reservations { get; set; }
    }
}
