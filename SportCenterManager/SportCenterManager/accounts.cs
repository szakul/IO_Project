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
    
    public partial class accounts
    {
        public accounts()
        {
            this.clients = new HashSet<clients>();
            this.employees = new HashSet<employees>();
        }
    
        public int ID { get; set; }
        public string LOGIN { get; set; }
        public string PASSWORD { get; set; }
    
        public virtual ICollection<clients> clients { get; set; }
        public virtual ICollection<employees> employees { get; set; }
    }
}