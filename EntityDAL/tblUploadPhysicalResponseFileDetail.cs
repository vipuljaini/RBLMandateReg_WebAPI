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
    
    public partial class tblUploadPhysicalResponseFileDetail
    {
        public long TUPRDID { get; set; }
        public Nullable<long> TUPRHID { get; set; }
        public string MandateID { get; set; }
        public string ReferenceNo { get; set; }
        public string CustomerName { get; set; }
        public string AcNo { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string DestinationBankIFSC { get; set; }
        public string UMRN { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseDesc { get; set; }
        public Nullable<bool> IsRegistered { get; set; }
        public Nullable<bool> IsRejected { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> IsValid { get; set; }
        public Nullable<bool> IsUploaded { get; set; }
        public string Status { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string MessageId { get; set; }
        public string UtilityCode { get; set; }
        public string StatusToBeUpload { get; set; }
    }
}