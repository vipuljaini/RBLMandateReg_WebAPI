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
    
    public partial class tblPennyDropAPIdetail
    {
        public long PennyDropId { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public string MERCHANT { get; set; }
        public string CheckSum { get; set; }
        public string IDFCextRefId { get; set; }
        public string dbtrAcctId_idfc { get; set; }
        public string remMobNb { get; set; }
        public Nullable<long> AppId { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
