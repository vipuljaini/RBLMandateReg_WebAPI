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

    }
}
