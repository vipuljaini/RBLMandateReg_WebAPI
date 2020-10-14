using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RBLMandateRegWebAPI.Models
{
    public class NPCIUnProcessMandate
    {
        public class GetDatavalue
        {
            public string AppId { get; set; }
           // public string AppId { get; set; }
        }
        public class GridBind
        {
          
            public Nullable<Int64> ActivityId { get; set; }
           
            public string ParentBankName { get; set; }
            public string CorporateName { get; set; }
            public string NoofRecord { get; set; } //char
            public string ImageUploads { get; set; }
            public string Noofverified { get; set; }
            public Nullable<Boolean> IsRejected { get; set; }
            public string UnprocessStatus { get; set; }
           
            public string CreatedOn { get; set; }
            public string CreatedBy { get; set; }
            public string UpdatedOn { get; set; }
            public string UpdatedBy { get; set; }

        }
    }
}