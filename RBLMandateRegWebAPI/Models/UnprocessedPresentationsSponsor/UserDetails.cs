using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RBLMandateRegWebAPI.Models.UnprocessedPresentationsSponsor
{
    public class UserDetails
    {
        public string EntityId { get; set; }
        public string UserId { get; set; }
    }


    public class GridDataTable
    {
        public Int64 SNo { get; set; }
        public Int32 PTID { get; set; }

        public string Presentationdate { get; set; }
        public string ActivityNo { get; set; }
        public string PresentationNo { get; set; }
        public string CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public string ApproveBy { get; set; }
        public string ApproveOn { get; set; }
        public string Branch { get; set; }
        public string Region { get; set; }
        public string Product { get; set; }
        public string BankName { get; set; }
        public string LastStatusOn { get; set; }
        public string Filestatus { get; set; }

        public string Lotno { get; set; }
        public Int32 noofrecord { get; set; }
        public string Lotstatus { get; set; }

    }

    public class DataTable0
    {
        public Int64 SrNo { get; set; }
        public string UMRN { get; set; }
        public string Amount { get; set; }
        public string RefNo { get; set; }
        public string Reason { get; set; }
        public string sponsorbankcode { get; set; }
        public string utilitycode { get; set; }
    }

    public class DataTable1
    {
        public Int64 SrNo { get; set; }
        public string UMRN { get; set; }
        public string Amount { get; set; }
        public string RefNo { get; set; }
        public string Reason { get; set; }
        public string sponsorbankcode { get; set; }
        public string utilitycode { get; set; }
    }

    public class DataTable2
    {
        public Int64 SrNo { get; set; }
        public string UMRN { get; set; }
        public string Amount { get; set; }
        public string RefNo { get; set; }
        public string Reason { get; set; }
        public string sponsorbankcode { get; set; }
        public string utilitycode { get; set; }
    }

    public class DataTable3
    {
        public Int64 SrNo { get; set; }
        public string UMRN { get; set; }
        public string Amount { get; set; }
        public string RefNo { get; set; }
        public string Reason { get; set; }
        public string sponsorbankcode { get; set; }
        public string utilitycode { get; set; }
    }
}