using RBLMandateRegWebAPI.Models.CorporateRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RBLMandateRegWebAPI.Controllers
{
    public class CorporateRequestController : ApiController
    {
        DataAccessLayer ObjDAL = new DataAccessLayer();

        [HttpPost]
        [Route("api/CorporateRequest/FetchData")]
        public Dictionary<string, object> FetchDataApi([FromBody] RequestFields Data)
        {
            return ObjDAL.FetchData(Data);

        }

        [HttpPost]
        [Route("api/CorporateRequest/BindDetailGrid")]
        public Dictionary<string, object> BindDetailGridApi([FromBody] RequestFields Data)
        {
            return ObjDAL.BindDetailGrid(Data);

        }

        //[HttpPost]
        //[Route("api/CorporateRequest/SaveCorpReqDetails")]
        //public Dictionary<string, object> SaveCorpReqDetailsApi([FromBody] RequestFields Data)
        //{
        //    return ObjDAL.SaveCorpReqDetails(Data);

        //}

    }
}
