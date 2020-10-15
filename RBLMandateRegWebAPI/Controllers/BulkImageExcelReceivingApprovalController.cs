using BusinessLibrary;
using EntityDAL;
using RBLMandateRegWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RBLMandateRegWebAPI.Controllers
{
    public class BulkImageExcelReceivingApprovalController : ApiController
    {
        [HttpPost]
        [Route("api/BulkImageExcelReceivingApproval/FetchData")]
        public BulkImageExcelReceivingApprovalModallist FetchData(BulkImageExcelReceivingApprovalModal Acdata)
        {
            try
            {
                BulkImageExcelReceivingApprovalModallist res = new BulkImageExcelReceivingApprovalModallist();
                QuickCheck_AngularEntities dbcontext = new QuickCheck_AngularEntities();
                var Result = dbcontext.MultipleResults("sp_Temp_BulkImageExcelReceivingApproval").With<BulkImageExcelReceivingApprovalModal>().Execute("@QueryType", "FetchData");
                res.BulkImageExcelReceivingApprovalModalList = Result[0].Cast<BulkImageExcelReceivingApprovalModal>().ToList();
                return res;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
