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
    
    public partial class tblBankDetail
    {
        public long BankdetailId { get; set; }
        public Nullable<double> BankID { get; set; }
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public Nullable<double> MICR_CODE { get; set; }
        public string BRANCH { get; set; }
        public Nullable<long> Createdby { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> Updatedby { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
