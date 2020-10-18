using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RBLMandateRegWebAPI.Models.DestUnprocessedPresent
{
    public class Binddata
    {
        public Int64 SNo { get; set; }
        public Int32 PTID { get; set; }
        public string Lotno { get; set; }
        public string LotAmount { get; set; }
        public string Presentationdate { get; set; }
        //public string ActivityNo { get; set; }
        //public string PresentationNo { get; set; }
        //public string CreatedOn { get; set; }
        //public string CreatedBy { get; set; }
        //public string UpdatedBy { get; set; }
        //public string UpdatedOn { get; set; }
        public string ApproveBy { get; set; }
        public string ApproveOn { get; set; }
        //public string Branch { get; set; }
        //public string Region { get; set; }
        //public string Product { get; set; }
        //public string BankName { get; set; }
        //public string LastStatusOn { get; set; }
        //public string Filestatus { get; set; }
        public Int32 noofrecord { get; set; }
        public string Lotstatus { get; set; }

    }

    public class Dstatus
    {
        public Int32 DestStatus { get; set; }
        public Int32 DestFStatus { get; set; }
    }

    public class Binddatadetail
    {
        public Int64 SNo { get; set; }
        public Int32 PTID { get; set; }
        public string umrnno { get; set; }
        public string refno { get; set; }
        //public string ActivityNo { get; set; }
        //public string PresentationNo { get; set; }
        //public string CreatedOn { get; set; }
        //public string CreatedBy { get; set; }
        //public string UpdatedBy { get; set; }
        //public string UpdatedOn { get; set; }
        public string amount { get; set; }
        //public string sponsorbankcode { get; set; }
        //public string Branch { get; set; }
        //public string Region { get; set; }
        //public string Product { get; set; }
        //public string BankName { get; set; }
        //public string LastStatusOn { get; set; }
        //public string Filestatus { get; set; }
        public string utilitycode { get; set; }
        public string AC { get; set; }
        public string AcHolderName { get; set; }


    }

    public class Binddatadetail1
    {
        public Int64 SNo { get; set; }
        public Int32 PTID { get; set; }
        public string umrnno { get; set; }
        public string refno { get; set; }
        //public string ActivityNo { get; set; }
        //public string PresentationNo { get; set; }
        //public string CreatedOn { get; set; }
        //public string CreatedBy { get; set; }
        //public string UpdatedBy { get; set; }
        //public string UpdatedOn { get; set; }
        public string amount { get; set; }
        //public string sponsorbankcode { get; set; }
        //public string Branch { get; set; }
        //public string Region { get; set; }
        //public string Product { get; set; }
        //public string BankName { get; set; }
        //public string LastStatusOn { get; set; }
        //public string Filestatus { get; set; }
        public string utilitycode { get; set; }
        public string reason { get; set; }
        public string AC { get; set; }
        public string AcHolderName { get; set; }


    }

    public class BindDestdetail
    {
        public Int64 SNo { get; set; }
        public Int32 PTID { get; set; }
        public string Presentationdate { get; set; }
        public string ActivityNo { get; set; }
        public string FileNo { get; set; }
        public string Receiveddateandtime { get; set; }
        public string CorporateName { get; set; }
        public string UtilityCode { get; set; }
        public string TotalRecordsInFile { get; set; }
        public string Successamount { get; set; }
        public string UnsuccessREcord { get; set; }
        public string RemainingRecord { get; set; }

    }
}