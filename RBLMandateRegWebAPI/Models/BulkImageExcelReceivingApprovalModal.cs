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
}