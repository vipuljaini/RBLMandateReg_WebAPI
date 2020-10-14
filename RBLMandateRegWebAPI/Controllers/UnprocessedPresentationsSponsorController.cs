using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntityDAL;
using BusinessLibrary;
using RBLMandateRegWebAPI.Models.UnprocessedPresentationsSponsor;

namespace RBLMandateRegWebAPI.Controllers
{
    public class UnprocessedPresentationsSponsorController : ApiController
    {
        UnprocessedPresentationsDAL obj = new UnprocessedPresentationsDAL();

        [HttpPost]
        [Route("api/UnprocessedPresentationsFront/BindHeaderGrid")]
        public Dictionary<string, object> BindHeaderGrid(UserDetails data)
        {
            return obj.BindHeaderGrid(data);
        }
    }
}
