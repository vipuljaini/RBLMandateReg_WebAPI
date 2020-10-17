using RBLMandateRegWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLibrary;
using EntityDAL;
using static RBLMandateRegWebAPI.Models.NPCIUnProcessMandate;

namespace RBLMandateRegWebAPI.Controllers
{
    public class NPCIUnProcessMandateController : ApiController
    {
        QuickCheck_AngularEntities dbcontext = new QuickCheck_AngularEntities();
        [HttpPost]
        [Route("api/NPCIUnProcessMandate/GetData/")]
        public Dictionary<string, object> BindDetails(GetDatavalue obj)
        {
            
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_NPCIUnprocessedMandates]").With<GridBind>().With<NPCIUnprocess>().Execute("@QueryType", "@Status", "GetPresentmentdata", Convert.ToString(obj.Status)));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPost]
        [Route("api/NPCIUnProcessMandate/GetDatadetail/")]
        public Dictionary<string, object> GetDatadetail(GetDatavalue obj)
        {

            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_NPCIUnprocessedMandates]").With<GridBind1>().With<NPCIUnprocess>().Execute("@QueryType", "@Status", "GetPresentmentdata1", Convert.ToString(obj.Status)));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPost]
        [Route("api/NPCIUnProcessMandate/GetData1/")]
        public Dictionary<string, object> GetData1(GetDatavalue obj)
        {

            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_NPCIUnprocessedMandates]").With<GridBind2>().With<NPCIUnprocess>().Execute("@QueryType", "@Status", "GetPresentmentdata2", Convert.ToString(obj.Status)));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPost]
        [Route("api/NPCIUnProcessMandate/GetData2/")]
        public Dictionary<string, object> GetData2(GetDatavalue obj)
        {

            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_NPCIUnprocessedMandates]").With<NPCIUnprocess>().Execute("@QueryType", "@Status","@UpdateID", "@Reason", "GetPresentmentdata3", Convert.ToString(obj.Status),Convert.ToString(obj.Mandateid),obj.Reason));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPost]
        [Route("api/NPCIUnProcessMandate/GetData3/")]
        public Dictionary<string, object> GetData3(GetDatavalue obj)
        {

            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_NPCIUnprocessedMandates]").With<NPCIUnprocess>().Execute("@QueryType", "@Status", "GetPresentmentdata4", Convert.ToString(obj.Status)));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPost]
        [Route("api/NPCIUnProcessMandate/GetData4/")]
        public Dictionary<string, object> GetData4(GetDatavalue obj)
        {

            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_NPCIUnprocessedMandates]").With<Bindcommondata>().Execute("@QueryType", "@Status", "GetPresentmentdata5", Convert.ToString(obj.Status)));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



    }
}
