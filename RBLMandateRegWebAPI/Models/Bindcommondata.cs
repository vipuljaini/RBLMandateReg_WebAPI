using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RBLMandateRegWebAPI.Models
{
    public class Bindcommondata
    {
        public Int64 MandateID { get; set; }
        public string Reference { get; set; }
        public string UtilityCode { get; set; }
        public string Corporate { get; set; }
        public string AcceptRefNo { get; set; }
        public string NPCIMsgId { get; set; }
        public string UMRN { get; set; }
        
        public string RejectionReason { get; set; }
        public string AccHolderName { get; set; }
        public string DateOnMandate { get; set; }
        public string Amount_Numeric { get; set; }
        public string AmountInWords { get; set; }
        public string AcNo { get; set; }
        public string IFSCMICR { get; set; }
        public string BankName { get; set; }
        public string Frequency { get; set; }
        public string SponsorBankCode { get; set; }
        
    }
}