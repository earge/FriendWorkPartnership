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
    
    public partial class TeamMember
    {
        public TeamMember()
        {
            this.MoneyIncomes = new HashSet<MoneyIncome>();
            this.MoneyIncomes1 = new HashSet<MoneyIncome>();
            this.MoneyOutgoings = new HashSet<MoneyOutgoing>();
            this.MoneyOutgoings1 = new HashSet<MoneyOutgoing>();
            this.MoneyOutgoings2 = new HashSet<MoneyOutgoing>();
            this.Projects = new HashSet<Project>();
            this.ProjectTasks = new HashSet<ProjectTask>();
            this.SysLogs = new HashSet<SysLog>();
            this.TeamMemberRoles = new HashSet<TeamMemberRole>();
        }
    
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string WebSiteAddress { get; set; }
        public string CV { get; set; }
        public bool IsApproved { get; set; }
        public bool Deleted { get; set; }
        public string ProfilePictureUrl { get; set; }
    
        public virtual ICollection<MoneyIncome> MoneyIncomes { get; set; }
        public virtual ICollection<MoneyIncome> MoneyIncomes1 { get; set; }
        public virtual ICollection<MoneyOutgoing> MoneyOutgoings { get; set; }
        public virtual ICollection<MoneyOutgoing> MoneyOutgoings1 { get; set; }
        public virtual ICollection<MoneyOutgoing> MoneyOutgoings2 { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<ProjectTask> ProjectTasks { get; set; }
        public virtual ICollection<SysLog> SysLogs { get; set; }
        public virtual ICollection<TeamMemberRole> TeamMemberRoles { get; set; }
    }
}
