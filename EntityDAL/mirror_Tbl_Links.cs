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
    
    public partial class mirror_Tbl_Links
    {
        public long LinkID { get; set; }
        public string LinkName { get; set; }
        public string url { get; set; }
        public string Purpose { get; set; }
        public int OrderNo { get; set; }
        public string IconName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public int ParetmenuID { get; set; }
    }
}
