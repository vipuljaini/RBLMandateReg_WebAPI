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
    
    public partial class tblCorporateEntityDetail
    {
        public long TCEDID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public Nullable<int> BankID { get; set; }
        public Nullable<int> SubMemberBankID { get; set; }
        public Nullable<int> Country { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<int> City { get; set; }
        public string UtilityCodeFirst { get; set; }
        public string UtilityCodeSec { get; set; }
        public string UtilityCodeThird { get; set; }
        public string UtilityCodeFourth { get; set; }
        public Nullable<int> BusinessSegmentCode { get; set; }
        public Nullable<int> RMID { get; set; }
        public Nullable<int> PSMID { get; set; }
        public string ContactPersonFirst { get; set; }
        public string ContactPersonDesg { get; set; }
        public string ContactNo { get; set; }
        public string FAX { get; set; }
        public string Arrangement { get; set; }
        public string PickUpPoint { get; set; }
        public string Location { get; set; }
        public string ContactPesonSecond { get; set; }
        public string ContactPersonName { get; set; }
        public string CustomerEmail { get; set; }
        public Nullable<int> EntityId { get; set; }
        public Nullable<int> AppId { get; set; }
        public string TokenID { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
