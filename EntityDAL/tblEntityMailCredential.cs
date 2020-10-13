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
    
    public partial class tblEntityMailCredential
    {
        public long EMId { get; set; }
        public string Amazon_SMTPHost { get; set; }
        public string Amazon_SMTPPort { get; set; }
        public Nullable<bool> Amazon_SMTPEnableSsl { get; set; }
        public string Amazon_UserId { get; set; }
        public string Amazon_MailPassword { get; set; }
        public string Amazon_FromMailId { get; set; }
        public Nullable<long> AppId { get; set; }
        public Nullable<long> EntityId { get; set; }
        public string Team { get; set; }
        public string AuthKey { get; set; }
        public string SenderId { get; set; }
        public string FilePath_SaveEditAPI { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string IsClientSmsApi { get; set; }
        public string EWebAppUrl { get; set; }
        public string EMandateURL { get; set; }
        public string MERCHANT { get; set; }
        public string MERCHANT_KEY { get; set; }
        public string CheckSum { get; set; }
        public string CheckSum_Key { get; set; }
        public Nullable<byte> IsLocal { get; set; }
        public Nullable<long> EBulkUploadMax_Count { get; set; }
        public string PAYU_BASE_URL { get; set; }
        public string E_Web_API_URl { get; set; }
        public string FileUploadPath { get; set; }
        public string DownloadFileName { get; set; }
    }
}
