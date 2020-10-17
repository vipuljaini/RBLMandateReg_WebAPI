using RBLMandateRegWebAPI.Models.BackUnProcessedMandateResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RBLMandateRegWebAPI.Controllers
{
    public class BackUnProcessedMandateResponseController : ApiController
    {
        DataAccessLayer ObjDAL = new DataAccessLayer();

        [HttpPost]
        [Route("api/BackUnProcessedMandateRespose/BindGrid")]
        public Dictionary<string, object> BindGrid([FromBody] RequestFields Data)
        {
            return ObjDAL.BindGrid(Data);

        }

        [HttpPost]
        [Route("api/BackUnProcessedMandateRespose/GetUMRN")]
        public Dictionary<string, object> GetUMRN([FromBody] RequestFields Data)
        {
            return ObjDAL.GetUMRN(Data);

        }

        [HttpPost]
        [Route("api/BackMandateFinalStatusRecive/BindGridFinal")]
        public Dictionary<string, object> BindGridFinal([FromBody] RequestFields Data)
        {
            return ObjDAL.BindGridFinal(Data);

        }
    }
}
