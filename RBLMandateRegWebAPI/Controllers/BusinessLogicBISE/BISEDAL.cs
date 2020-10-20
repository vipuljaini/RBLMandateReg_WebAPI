using BusinessLibrary;
using EntityDAL;
using RBLMandateRegWebAPI.Models.BISE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace RBLMandateRegWebAPI.Controllers.BusinessLogicBISE
{
    public class BISEDAL
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

        public Dictionary<string, object> SentToChecker()
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Proc_BISE]").With<Response>().Execute("@QueryType", "SentToChecker"));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> Approve()
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Proc_BISE]").With<Response>().Execute("@QueryType", "Approve"));
                return Result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> ActivityCompleted()
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Proc_BISE]").With<Response>().Execute("@QueryType", "ActivityCompleted"));
                return Result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Dictionary<string, object> Save()
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Proc_BISE]").With<Response>().Execute("@QueryType", "Save"));
                return Result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> IsSave()
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Proc_BISE]").With<Response>().Execute("@QueryType", "IsSave"));
                return Result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<string, object> IsSentToChecker()
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Proc_BISE]").With<Response>().Execute("@QueryType", "IsSentToChecker"));
                return Result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Dictionary<string, object> IsApprove()
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Proc_BISE]").With<Response>().Execute("@QueryType", "IsApprove"));
                return Result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}