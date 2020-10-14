using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RBLMandateRegWebAPI.Models.DestUnprocessedPresent;
using BusinessLibrary;
using EntityDAL;


namespace RBLMandateRegWebAPI.Controllers
{
    public class DestUnprocessedPresentationControllerController : ApiController
    {
        QuickCheck_AngularEntities dbcontext = new QuickCheck_AngularEntities();
        [HttpPost]
        [Route("api/DestPresentment/Getdata")]
        public Dictionary<string, object> DestPresentment([FromBody] DestPresent Getdata)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[TEMPDESTPRESENT]").With<Binddata>().With<Dstatus>().Execute("@QueryType", "@Status", "GetPresentmentdata", Convert.ToString(Getdata.Status)));

                return Result;

            }
            catch (Exception ex) { throw ex; }
        }


        [HttpPost]
        [Route("api/DestPresentmentdetails/Getdata2/")]
        public Dictionary<string, object> DestPresentmentdetails([FromBody] DestPresent Getdata)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[TEMPDESTPRESENT]").With<Binddatadetail>().With<Dstatus>().Execute("@QueryType", "@Status", "GetPresentmentdata2", Convert.ToString(Getdata.Status)));

                return Result;

            }
            catch (Exception ex) { throw ex; }
        }


       


        [HttpPost]
        [Route("api/DestPresentment/Getdata1")]
        public Dictionary<string, object> Getdata1([FromBody] DestPresent Getdata)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[TEMPDESTPRESENT]").With<Binddatadetail>().With<Binddatadetail1>().With<Dstatus>().Execute("@QueryType", "@Status", "GetPresentmentdata1", Convert.ToString(Getdata.Status)));

                return Result;

            }
            catch (Exception ex) { throw ex; }
        }


        [HttpPost]
        [Route("api/DestPresentment2/Getdata2")]
        public Dictionary<string, object> Getdata2([FromBody] DestPresent Getdata)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[TEMPDESTPRESENT]").With<Dstatus>().Execute("@QueryType", "@Status", "GetPresentmentdata4", Convert.ToString(Getdata.Status)));

                return Result;

            }
            catch (Exception ex) { throw ex; }
        }


        [HttpPost]
        [Route("api/DestPresentment3/Getdata3")]
        public Dictionary<string, object> Getdata3([FromBody] DestPresent Getdata)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[TEMPDESTPRESENT]").With<Dstatus>().Execute("@QueryType", "@Status", "GetPresentmentdata3", Convert.ToString(Getdata.Status)));

                return Result;

            }
            catch (Exception ex) { throw ex; }
        }



    }
}
