using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RBLMandateRegWebAPI.Models
{
    public class AccountValidationModel
    {
        public string MandateId { get; set; }
        //public string IsliveInNach { get; set; }
        public string ActivityId { get; set; }
        public string AcNo { get; set; }
        public string IFSC { get; set; }
        public string MICR { get; set; }
        public string UserId { get; set; }
        public string AppId { get; set; }
        public string EntityId { get; set; }

    }
    public class BulkImageExcelReceivingApprovalModal
    { 
        public string Sno { get; set; }
        public string BankName { get; set; }
        public string CorPoratename { get; set; }
        public string ActivityNo { get; set; }
        public string CountRcds { get; set; }
        public string ImageUpload { get; set; }
        public string NoOfVerified { get; set; }
        public string NoOfRejected { get; set; }
        public string UploadedBy { get; set; }
        public string UploadedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdateOn { get; set; }
        public string Status { get; set; }
        public string FillMandate { get; set; }
        public string CancelActivity { get; set; }

    }
    public class BulkImageExcelReceivingApprovalModallist
    {
        public List<BulkImageExcelReceivingApprovalModal> BulkImageExcelReceivingApprovalModalList { get; set; }
        
    }

    public class BulkImageExcelReceivingApprovalModalReq
    {
        public string AppId { get; set; }
    }

    public class GetMandateData
    {
        public string MandateId { get; set; }
        public string Frequency { get; set; }
        public string DebitType { get; set; }
        public string DateOnMandate { get; set; }
        public string Refrence1 { get; set; }
        public string Refrence2 { get; set; }
        public string PhoneNumber { get; set; }
        public string Customer2 { get; set; }
        public string JPGPath { get; set; }

        public string Customer3 { get; set; }
        public string Customer1 { get; set; }
        public string Todate { get; set; }
        public string FromDate { get; set; }
        public string AmountRupeesInWords { get; set; }
        public string AmountRupees { get; set; }
        public string BankName { get; set; }
        public string EmailId { get; set; }

        public string AcNo { get; set; }
        public string IFSC { get; set; }
        public string ToDebit { get; set; }
        public string UtilityCode { get; set; }
        public string SponsorbankCode { get; set; }
        //public Int64 ActivityId { get; set; }
        public string CategoryCode { get; set; }
        
    }
}