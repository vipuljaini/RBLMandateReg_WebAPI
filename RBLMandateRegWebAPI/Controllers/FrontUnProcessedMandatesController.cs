using RBLMandateRegWebAPI.Models.FrontUnProcessedMandates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RBLMandateRegWebAPI.Controllers
{
    public class FrontUnProcessedMandatesController : ApiController
    {
        DataAccessLayer ObjDAL = new DataAccessLayer();

        [HttpPost]
        [Route("api/FrontUnProcessedMandate/BindGrid")]
        public Dictionary<string, object> BindGrid([FromBody] RequestFields Data)
        {
            return ObjDAL.BindGrid(Data);

        }

        [HttpPost]
        [Route("api/FrontUnderProcessedMandate/BindGridUnderProcess")]
        public Dictionary<string, object> BindGridUnderProcess([FromBody] RequestFields Data)
        {
            return ObjDAL.BindGridUnderProcess(Data);

        }

        [HttpPost]
        [Route("api/FrontUnderProcessedMandate/GetUMRN")]
        public Dictionary<string, object> GetUMRN([FromBody] RequestFields Data)
        {
            return ObjDAL.GetUMRN(Data);

        }

        [HttpPost]
        [Route("api/FrontUnderProcessedMandate/GetResponse")]
        public Dictionary<string, object> GetResponse([FromBody] RequestFields Data)
        {
            return ObjDAL.GetResponse(Data);

        }
    }
}
