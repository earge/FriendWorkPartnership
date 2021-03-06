//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EARGE.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class MoneyOutgoing
    {
        public int Id { get; set; }
        public int TeamMemberId { get; set; }
        public Nullable<int> TaskId { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
        public int CreateUserId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int IsApproved { get; set; }
        public int Deleted { get; set; }
        public Nullable<int> ApprovedMemberId { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public Nullable<int> ProjectId { get; set; }
    
        public virtual Project Project { get; set; }
        public virtual ProjectTask ProjectTask { get; set; }
        public virtual TeamMember TeamMember { get; set; }
        public virtual TeamMember TeamMember1 { get; set; }
        public virtual TeamMember TeamMember2 { get; set; }
    }
}
