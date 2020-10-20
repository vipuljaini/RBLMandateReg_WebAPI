using BusinessLibrary;
using EntityDAL;
using System;
using System.Collections.Generic;
using Encryptions;
using System.Linq;
using System.Web;

namespace RBLMandateRegWebAPI.Models.Back_Office_Mandate_Request
{
    public class DataAccessLayer
    {
        QuickCheck_AngularEntities context = new QuickCheck_AngularEntities();


        public Dictionary<string, object> BindGrid(MandateRequest MandateRequestData)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_RBL_BackOffice]").With<MandateRequestData>().Execute("@QueryType","@Userid", "BindUnProcessGrid",Dbsecurity.Decrypt(MandateRequestData.UserID)));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Dictionary<string, object> UnderProcessHeader(MandateRequest MandateRequestData)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_RBL_BackOffice]").With<UnderprocessHeaderData>().Execute("@QueryType", "@Userid", "BindUnderProcessHeader", Dbsecurity.Decrypt(MandateRequestData.UserID)));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Dictionary<string, object> UnderProcessDetails(MandateRequest MandateRequestData)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_RBL_BackOffice]").With<MandateRequestData>().Execute("@QueryType", "@BatchNo", "BindUnderProcessDetails",MandateRequestData.BatchNo));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> UpdateHeaderStatus(MandateRequest MandateRequestData)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_RBL_BackOffice]").With<MandateRequestData>().Execute("@QueryType", "@BatchNo", "UpdateHeaderStatus", MandateRequestData.BatchNo));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    public Dictionary<string, object> ProcessedMandateResponseFetchData(MandateRequest MandateRequestData)
    {
        try
        {
            var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_RBL_BackOffice]").With<BindFields>().Execute("@QueryType", "ProcessedMandateResponseFetchData"));
            return Result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

        public Dictionary<string, object> ProcessedMandateResponseShowRespons(MandateRequest MandateRequestData)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_RBL_BackOffice]").With<BindFields>().Execute("@QueryType", "ProcessedMandateResponseShowResponse"));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> RejectMandate(MandateRequest MandateRequestData)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_RBL_BackOffice]").With<MandateRequestData>().Execute("@QueryType", "@UserId", "BindRejectedMandates",Dbsecurity.Decrypt(MandateRequestData.UserID)));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}