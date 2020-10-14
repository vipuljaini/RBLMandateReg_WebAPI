using RBLMandateRegWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static RBLMandateRegWebAPI.Models.NPCIUnProcessMandate;

namespace RBLMandateRegWebAPI.Controllers
{
    public class NPCIUnProcessMandateController : ApiController
    {
        NPCIUnProcessMandateDAL obj1 = new NPCIUnProcessMandateDAL();
        [HttpPost]
        [Route("api/NPCIUnProcessMandate/GetData/")]
        public Dictionary<string, object> BindDetails(GetDatavalue obj)
        {
            try
            {
                return obj1.BindGrid(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
