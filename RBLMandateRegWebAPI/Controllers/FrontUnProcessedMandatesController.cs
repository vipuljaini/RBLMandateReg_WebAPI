using RBLMandateRegWebAPI.Models.FrontUnProcessedMandates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLibrary;
using EntityDAL;
namespace RBLMandateRegWebAPI.Controllers
{
    public class FrontUnProcessedMandatesController : ApiController
    {
        QuickCheck_AngularEntities context = new QuickCheck_AngularEntities();

        [HttpPost]
        [Route("api/FrontUnProcessedMandate/BindGrid")]
        public Dictionary<string, object> BindGrid([FromBody] RequestFields Data)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_FrontUnProcessedMandate]").With<BindFields>().With<RequestFields>().Execute("@QueryType", "@Status", "BindFrontGrid", Data.Status));  //Dbsecurity.Decrypt(Data.UserId), Dbsecurity.Decrypt(Data.EntityId)
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPost]
        [Route("api/FrontUnProcessedMandate/BindGrid1")]
        public Dictionary<string, object> BindGrid1([FromBody] RequestFields Data)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_FrontUnProcessedMandate]").With<BindFields>().With<RequestFields>().Execute("@QueryType", "@Status", "BindProcessedFrontGrid", Data.Status));  //Dbsecurity.Decrypt(Data.UserId), Dbsecurity.Decrypt(Data.EntityId)
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPost]
        [Route("api/FrontUnProcessedMandate/BindGrid2")]
        public Dictionary<string, object> BindGrid2([FromBody] RequestFields Data)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_FrontUnProcessedMandate]").With<BindFields>().With<RequestFields>().Execute("@QueryType", "@Status", "BindProcessedFrontGrid1", Data.Status));  //Dbsecurity.Decrypt(Data.UserId), Dbsecurity.Decrypt(Data.EntityId)
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //[HttpPost]
        //[Route("api/FrontUnderProcessedMandate/BindGridUnderProcess")]
        //public Dictionary<string, object> BindGridUnderProcess([FromBody] RequestFields Data)
        //{
        //    return ObjDAL.BindGridUnderProcess(Data);

        //}

        //[HttpPost]
        //[Route("api/FrontUnderProcessedMandate/GetUMRN")]
        //public Dictionary<string, object> GetUMRN([FromBody] RequestFields Data)
        //{
        //    return ObjDAL.GetUMRN(Data);

        //}

        //[HttpPost]
        //[Route("api/FrontUnderProcessedMandate/GetResponse")]
        //public Dictionary<string, object> GetResponse([FromBody] RequestFields Data)
        //{
        //    return ObjDAL.GetResponse(Data);

        //}
    }
}
