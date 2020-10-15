using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RBLMandateRegWebAPI.Models
{
    public class NPCIUnProcessMandate
    {
        public class GetDatavalue
        {
            public string AppId { get; set; }
           // public string AppId { get; set; }
        }
        public class GridBind
        {
          
            public Nullable<Int64> ActivityId { get; set; }
           
            public string ParentBankName { get; set; }
            public string CorporateName { get; set; }
            public string NoofRecord { get; set; } //char
            public string ImageUploads { get; set; }
            public string Noofverified { get; set; }
            public Nullable<Boolean> IsRejected { get; set; }
            public string UnprocessStatus { get; set; }
           
            public string CreatedOn { get; set; }
            public string CreatedBy { get; set; }
            public string UpdatedOn { get; set; }
            public string UpdatedBy { get; set; }

        }

        public class GridBind1
        {

          //  public Nullable<Int64> ActivityId { get; set; }

            public string CategoryCode { get; set; }
            public string UtilityCode { get; set; }
            public string DateOnMandate { get; set; } //char
            public string SponsorbankCode { get; set; }
            public string ToDebit { get; set; }
           // public Nullable<Boolean> IsRejected { get; set; }
            public string AcNo { get; set; }

            public string IFSC { get; set; }
            public Nullable<Double> MICR { get; set; }
            public string AmountRupees { get; set; }
            public string AmountRupeesInWords { get; set; }

            public string Frequency { get; set; }
            public string DebitType { get; set; }
            public string Refrence1 { get; set; }
            public string Refrence2 { get; set; }
            public string PhoneNumber { get; set; }
            public string EmailId { get; set; }
        }
    }
}