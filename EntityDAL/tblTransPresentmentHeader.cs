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
    
    public partial class tblTransPresentmentHeader
    {
        public long TransheaderId { get; set; }
        public string FileNo { get; set; }
        public string Date { get; set; }
        public string BankName { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<long> ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApprovedOn { get; set; }
        public Nullable<System.DateTime> LastStatus { get; set; }
        public string FileStatus { get; set; }
        public string BankResponseStatus { get; set; }
        public Nullable<long> AppId { get; set; }
        public string ActivityId { get; set; }
        public Nullable<bool> ActivityType { get; set; }
        public Nullable<long> RequestType { get; set; }
        public string BankCode { get; set; }
        public Nullable<long> EntityId { get; set; }
        public Nullable<long> ReqCount { get; set; }
        public string PresentmentHeaderNo { get; set; }
        public string APIFileNo { get; set; }
        public Nullable<System.DateTime> SendToBankDate { get; set; }
        public string SponsorbankId { get; set; }
    }
}