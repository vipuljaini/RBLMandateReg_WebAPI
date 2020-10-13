using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLibrary;

using EntityDAL;
using RBLMandateRegWebAPI.Models.BISE;

namespace RBLMandateRegWebAPI.Controllers.BISE
{
    public class BISEController : ApiController
    {
        QuickCheck_AngularEntities dbcontext = new QuickCheck_AngularEntities();
        public Dictionary<string, object> BindHeader()
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Proc_BISE]").With<BISEHeader>().Execute("@QueryType", "Header"));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> BindDetails()
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Proc_BISE]").With<BISEDetails>().Execute("@QueryType", "Details"));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
