//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblLeaveDetail
    {
        public int LeaveId { get; set; }
        public Nullable<int> EmpId { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public string LeaveType { get; set; }
        public string LeaveReason { get; set; }
    }
}
