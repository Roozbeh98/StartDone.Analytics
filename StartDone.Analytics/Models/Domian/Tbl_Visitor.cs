//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StartDone.Analytics.Models.Domian
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Visitor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Visitor()
        {
            this.Tbl_PageVisit = new HashSet<Tbl_PageVisit>();
            this.Tbl_Session = new HashSet<Tbl_Session>();
        }
    
        public int Visitor_ID { get; set; }
        public int Visitor_IPID { get; set; }
        public int Visitor_TypeCodeID { get; set; }
        public System.DateTime Visitor_CreateDateTime { get; set; }
    
        public virtual Tbl_Code Tbl_Code { get; set; }
        public virtual Tbl_IPAddress Tbl_IPAddress { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_PageVisit> Tbl_PageVisit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Session> Tbl_Session { get; set; }
    }
}
