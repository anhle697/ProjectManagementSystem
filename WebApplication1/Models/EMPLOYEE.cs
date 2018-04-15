//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMPLOYEE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLOYEE()
        {
            this.PROJECTs = new HashSet<PROJECT>();
            this.TIMESHEETs = new HashSet<TIMESHEET>();
        }
    
        public int Employee_ID { get; set; }
        public string F_name { get; set; }
        public string Employee_type { get; set; }
        public double Hourly_rate { get; set; }
        public string M_name { get; set; }
        public string L_name { get; set; }
        public System.DateTime Last_update { get; set; }
        public string Last_update_by { get; set; }
        public string Email_address { get; set; }
    
        public virtual EMPLOYEE_DELIVERABLE EMPLOYEE_DELIVERABLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROJECT> PROJECTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIMESHEET> TIMESHEETs { get; set; }
    }
}