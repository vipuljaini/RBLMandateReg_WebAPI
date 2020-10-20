using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntityDAL;
using BusinessLibrary;
using System.IO;
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

        [HttpPost]
        [Route("api/UnprocessedPresentationsFront/FrontUnprocessedPresentationsDetails")]
        public Dictionary<string, object> BindDetailsGrid(UserDetails data)
        {
            return obj.BindDetailsGrid(data);
        }


        [HttpPost]
        [Route("api/UnprocessedPresentationsFront/SubmitActivityData")]
        public Dictionary<string, object> SubmitActivityData(UserDetails data)
        {
            return obj.SubmitActivityData(data);
        }



        [HttpPost]
        [Route("api/UnprocessedPresentationsFront/BindActivityDetails_grid")]
        public Dictionary<string, object> BindActivityDetails_grid(UserDetails data)
        {
            return obj.BindActivityDetails_grid(data);
        }
        [HttpPost]
        [Route("api/UnprocessedPresentationsFront/SubmitBank_click")]
        public Dictionary<string, object> SubmitBank_click(UserDetails data)
        {
            return obj.SubmitBank_click(data);
        }
        [HttpPost]
        [Route("api/UnprocessedPresentationsFront/GetStatus_click")]
        public Dictionary<string, object> GetStatus_click(UserDetails data)
        {
            return obj.GetStatus_click(data);
        }
    }
}
