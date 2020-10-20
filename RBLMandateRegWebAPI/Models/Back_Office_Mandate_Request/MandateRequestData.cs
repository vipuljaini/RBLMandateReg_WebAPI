using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RBLMandateRegWebAPI.Models.Back_Office_Mandate_Request
{
    public class MandateRequestData
    {
        public Int64 MandateId { get; set; }
        public string Frequency { get; set; }
        public string DebitType { get; set; }
        public DateTime DateOnMandate { get; set; }
        public string Refrence1 { get; set; }
        public Int64 ScanCount { get; set; }
        public Int64 PrintCount { get; set; }
        public string Customer1 { get; set; }
        public string AmountRupeesInWords { get; set; }
        public string AmountRupees { get; set; }
        public string BankName { get; set; }
        public string AcNo { get; set; }
        public string IFSC { get; set; }
        public string ToDebit { get; set; }
        public double MICR { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UtilityCode { get; set; }
        public string SponsorbankCode { get; set; }
        public string RejectedReason { get; set; }
        public string MandateMode { get; set; }
        public string MandateType { get; set; }
        public string UMRN { get; set; }
        public string CorporateName { get; set; }
        public string NPCIMsgId { get; set; }
    }

    public class UnderprocessHeaderData
    {
        public string RBLBatchNo { get; set; }
        public string SponsorbankCode { get; set; }
        public Int32 NoOfRecords { get; set; }
        public string HeaderStatus { get; set; }
    }

    public class BindFields
    {
        public string MandateStatus { get; set; }
        public string MandateId { get; set; }
        public string Refrence1 { get; set; }
        public string UtilityCode { get; set; }
        public string AcceptRefNo { get; set; }
        public string NPCIMsgId { get; set; }
        public string UMRN { get; set; }
        public Nullable<Boolean> IsAggregator { get; set; }
        public string MandateMode { get; set; }
        public string AutoRejectReason { get; set; }
        public string RejectedReason { get; set; }
        public string MandateType { get; set; }
        public string Customer1 { get; set; }
        public string DateOnMandate { get; set; }
        public string AmountRupees { get; set; }
        public string AmountRupeesInWords { get; set; }
        public string AcNo { get; set; }
        public string IFSC { get; set; }
        public string BankName { get; set; }
        public string Frequency { get; set; }
        public string DebitType { get; set; }
        public string ToDebit { get; set; }
        public string SponsorbankCode { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string NPCIErrorDesc { get; set; }
        public string CorporateName { get; set; }
    }
}