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
    
    public partial class tblCorpOnBoardingContactPerson
    {
        public long TCOBCP { get; set; }
        public Nullable<long> TCEDID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string ContactNo { get; set; }
        public string FaxNo { get; set; }
        public string Address { get; set; }
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
