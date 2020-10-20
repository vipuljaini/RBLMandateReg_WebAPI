using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLibrary;
using EntityDAL;
using RBLMandateRegWebAPI.Models.Back_Office_Mandate_Request;

namespace RBLMandateRegWebAPI.Controllers
{
    public class BackUnProcessedMandateRequestController : ApiController
    {
        QuickCheck_AngularEntities context = new QuickCheck_AngularEntities();
        DataAccessLayer objRBLMandateRequest = new DataAccessLayer();
        DataTable dt = new DataTable();

        [HttpPost]
        [Route("api/RBLMandate/BindGrid")]
        public Dictionary<string, object> BindGrid([FromBody] MandateRequest MandateRequestData)
        {
            return objRBLMandateRequest.BindGrid(MandateRequestData);

        }


        [HttpPost]
        [Route("api/RBLMandate/UnderProcessHeader")]
        public Dictionary<string, object> UnderProcessHeader([FromBody] MandateRequest MandateRequestData)
        {
            return objRBLMandateRequest.UnderProcessHeader(MandateRequestData);

        }

        [HttpPost]
        [Route("api/RBLMandate/UnderProcessDetails")]
        public Dictionary<string, object> UnderProcessDetails([FromBody] MandateRequest MandateRequestData)
        {
            return objRBLMandateRequest.UnderProcessDetails(MandateRequestData);

        }


        [HttpPost]
        [Route("api/RBLMandate/UpdateHeaderStatus")]
        public Dictionary<string, object> UpdateHeaderStatus([FromBody] MandateRequest MandateRequestData)
        {
            return objRBLMandateRequest.UpdateHeaderStatus(MandateRequestData);

        }



        [HttpPost]
        [Route("api/RBLMandate/ProcessedMandateResponseFetchData")]
        public Dictionary<string, object> ProcessedMandateResponseFetchData([FromBody] MandateRequest MandateRequestData)
        {
            return objRBLMandateRequest.ProcessedMandateResponseFetchData(MandateRequestData);

        }

        [HttpPost]
        [Route("api/RBLMandate/ProcessedMandateResponseShowResponse")]
        public Dictionary<string, object> ProcessedMandateResponseShowRespons([FromBody] MandateRequest MandateRequestData)
        {
            return objRBLMandateRequest.ProcessedMandateResponseShowRespons(MandateRequestData);

        }


         [HttpPost]
        [Route("api/RBLMandate/RejectMandate")]
        public Dictionary<string, object> RejectMandate([FromBody] MandateRequest MandateRequestData)
        {
            return objRBLMandateRequest.RejectMandate(MandateRequestData);

        }

    }
}
