//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCreateMandate
    {
        public int ID { get; set; }
        public Nullable<int> MandateId { get; set; }
        public string RefNo { get; set; }
        public string CustName { get; set; }
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string AcNo { get; set; }
        public string EmailID { get; set; }
        public string EntityID { get; set; }
        public string ActivityID { get; set; }
        public string UserID { get; set; }
        public Nullable<bool> IsSendMail { get; set; }
        public Nullable<System.DateTime> CreateON { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdateOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<long> SmsCount { get; set; }
        public Nullable<long> EmailCount { get; set; }
    }
}