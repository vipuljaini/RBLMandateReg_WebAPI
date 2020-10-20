using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RBLMandateRegWebAPI.Models.CorporateRequest
{
    public class BindGridFields
    {
        public string CorporateName { get; set; }
        public string SubmissionDate { get; set; }
        public Nullable<Int32> TotalNoOfrecords { get; set; }
        public string UtilityCode { get; set; }
        public string FileNo { get; set; }
        public string MandateId { get; set; }
        public string Refrence1 { get; set; }
        public string AcNo { get; set; }
        public string AmountRupees { get; set; }
        public string Customer1 { get; set; }
    }
}