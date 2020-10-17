using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RBLMandateRegWebAPI.Models.BackUnProcessedMandateResponse
{
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