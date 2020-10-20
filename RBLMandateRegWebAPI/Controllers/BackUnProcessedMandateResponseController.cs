using RBLMandateRegWebAPI.Models.BackUnProcessedMandateResponse;
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
    public class BackUnProcessedMandateResponseController : ApiController
    {
        //DataAccessLayer ObjDAL = new DataAccessLayer();
        QuickCheck_AngularEntities context = new QuickCheck_AngularEntities();
        [HttpPost]
        [Route("api/BackUnProcessedMandateRespose/BindGrid")]
        public Dictionary<string, object> BindGrid([FromBody] RequestFields Data)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_FrontUnProcessedMandate]").With<BindFields>().With<RequestFields>().Execute("@QueryType", "@Status", "BindGrid", Data.Status));  //Dbsecurity.Decrypt(Data.UserId), Dbsecurity.Decrypt(Data.EntityId)
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPost]
        [Route("api/BackUnProcessedMandateRespose/BindGrid1")]
        public Dictionary<string, object> BindGrid1([FromBody] RequestFields Data)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_FrontUnProcessedMandate]").With<BindFields>().Execute("@QueryType", "@Status", "@Status1", "BindGrid1", Data.Status,Data.Status1));  //Dbsecurity.Decrypt(Data.UserId), Dbsecurity.Decrypt(Data.EntityId)
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPost]
        [Route("api/BackUnProcessedMandateRespose/BindGrid2")]
        public Dictionary<string, object> BindGrid2([FromBody] RequestFields Data)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_FrontUnProcessedMandate]").With<BindFields1>().Execute("@QueryType", "@Status", "@Status1", "BindGrid2", Data.Status, Data.Status1));  //Dbsecurity.Decrypt(Data.UserId), Dbsecurity.Decrypt(Data.EntityId)
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //[HttpPost]
        //[Route("api/BackUnProcessedMandateRespose/GetUMRN")]
        //public Dictionary<string, object> GetUMRN([FromBody] RequestFields Data)
        //{
        //    return ObjDAL.GetUMRN(Data);

        //}

        //[HttpPost]
        //[Route("api/BackMandateFinalStatusRecive/BindGridFinal")]
        //public Dictionary<string, object> BindGridFinal([FromBody] RequestFields Data)
        //{
        //    return ObjDAL.BindGridFinal(Data);

        //}
    }
}
