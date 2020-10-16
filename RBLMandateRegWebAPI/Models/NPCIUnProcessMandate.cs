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
            public string Status { get; set; }
            public int Mandateid { get; set; }
            public string Reason { get; set; }
        }
        public class GridBind
        {
          
            public Int64 SNo { get; set; }
           
            public string SponsorbankCode { get; set; }
            public string UtilityCode { get; set; }
            public string CorporateName { get; set; } //char
            public Int32 NoofRecord { get; set; }
            public Int32 nar { get; set; }
            public Int32 noofrejected { get; set; }
            public string fileprocessedby { get; set; }
           
            public string fileprocessedon { get; set; }
            public string fileapproveby { get; set; }
            public string fileapproveon { get; set; }
            public string status { get; set; }

        }

        public class GridBind1
        {

            public Int64 Sno { get; set; }

            public string UMRN { get; set; }
            public string DateOnMandate { get; set; }
            public string Reference1 { get; set; } //char
            public string Customer1 { get; set; }
            public string AccountNumber { get; set; }
            public string BankName { get; set; }
            public string IFSC { get; set; }
            public string Status { get; set; }
        }





        public class GridBind2
        {

            //  public Nullable<Int64> ActivityId { get; set; }

            public string CategoryCode { get; set; }
            public string UtilityCode { get; set; }
            public string DateOnMandate { get; set; } //char
            public string SponsorbankCode { get; set; }
            public string ToDebit { get; set; }
            // public Nullable<Boolean> IsRejected { get; set; }
            public string AcNo { get; set; }
            public string BankName { get; set; }
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
            public string PeriodFrom { get; set; }
            public string PeriodTo { get; set; }
            public Int32 UntilCancelled { get; set; }
            public string Customer1 { get; set; }
            public string ImageName { get; set; }
        }
    }
}