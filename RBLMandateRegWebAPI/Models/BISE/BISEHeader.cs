using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RBLMandateRegWebAPI.Models.BISE
{
    public class BISEHeader
    {
        public Int64 SrNo { get; set; }
        public string Bank_Name { get; set; }
        public string CorporateName { get; set; }
        
        public string ActivityNo { get; set; }
        public string Noofrecipient { get; set; }
        public string ImageUpload { get; set; }
        public string NoofVerified { get; set; }
        public string NoOfRejected { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdateOn { get; set; }
        public string Status { get; set; }
    }

    public class BISEDetails
    {
        public Int64 SrNo { get; set; }
        public string MandateId { get; set; }
        public string DateOnMandate { get; set; }
        public string Refrence1 { get; set; }
        public string Customer1 { get; set; }
        public string AcNo { get; set; }
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdateOn { get; set; }
        public string Status { get; set; }
    }

    public class Response
    {
        public string Result { get; set; }
        
    }
}