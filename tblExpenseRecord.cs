//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MD_MUNTAKIM_BIN_HOSSAIN_P00194964
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblExpenseRecord
    {
        public int erId { get; set; }
        public int MonthId { get; set; }
        public int PaymentTypeId { get; set; }
        public decimal Cost { get; set; }
        public Nullable<int> ecId { get; set; }
        public string Description { get; set; }
        public Nullable<int> expitemId { get; set; }
        public int UserId { get; set; }
    
        public virtual tblExpenseCategory tblExpenseCategory { get; set; }
        public virtual tblExpenseItem tblExpenseItem { get; set; }
        public virtual tblMonth tblMonth { get; set; }
        public virtual tblPaymentType tblPaymentType { get; set; }
        public virtual tblUser tblUser { get; set; }
    }
}