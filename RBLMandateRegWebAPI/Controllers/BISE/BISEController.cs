using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLibrary;

using EntityDAL;
using RBLMandateRegWebAPI.Controllers.BusinessLogicBISE;
using RBLMandateRegWebAPI.Models.BISE;
using System.IO;

namespace RBLMandateRegWebAPI.Controllers.BISE
{
    public class BISEController : ApiController
    {
        BISEDAL obj = new BISEDAL();
        [HttpPost]
        [Route("api/BISETemp/BindHeader/")]
        public Dictionary<string, object> BindHeader()
        {
            try
            {
                return obj.BindHeader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        [HttpPost]
        [Route("api/BISETemp/BindDetails/")]
        public Dictionary<string, object> BindDetails()
        {
            try
            {
                return obj.BindDetails();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        [HttpPost]
        [Route("api/BISETemp/SentToChecker/")]
        public Dictionary<string, object> SentToChecker()
        {
            try
            {
                return obj.SentToChecker();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpPost]
        [Route("api/BISETemp/Approve/")]
        public Dictionary<string, object> Approve()
        {
            try
            {
                return obj.Approve();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [HttpPost]
        [Route("api/BISETemp/ActivityCompleted/")]
        public Dictionary<string, object> ActivityCompleted()
        {
            try
            {
                return obj.ActivityCompleted();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpPost]
        [Route("api/BISETemp/Save/")]
        public Dictionary<string, object> Save()
        {
            try
            {
                return obj.Save();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("api/BISETemp/IsSave/")]
        public Dictionary<string, object> IsSave()
        {
            try
            {
                return obj.IsSave();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpPost]
        [Route("api/BISETemp/IsSentToChecker/")]
        public Dictionary<string, object> IsSentToChecker()
        {
            try
            {
                return obj.IsSentToChecker();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpPost]
        [Route("api/BISETemp/IsApprove/")]
        public Dictionary<string, object> IsApprove()
        {
            try
            {
                return obj.IsApprove();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
