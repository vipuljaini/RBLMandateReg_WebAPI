using BusinessLibrary;
using EntityDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RBLMandateRegWebAPI.Models.FrontUnProcessedMandates
{
    public class DataAccessLayer
    {
        QuickCheck_AngularEntities context = new QuickCheck_AngularEntities();


        public Dictionary<string, object> BindGrid(RequestFields Data)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_FrontUnProcessedMandate]").With<BindFields>().Execute("@QueryType","@UserId", "@EntityId", "BindGrid", "2", "2" ));  //Dbsecurity.Decrypt(Data.UserId), Dbsecurity.Decrypt(Data.EntityId)
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> BindGridUnderProcess(RequestFields Data)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_FrontUnProcessedMandate]").With<BindFields>().Execute("@QueryType", "@UserId", "@EntityId", "BindGridUnderProcess", "2", "2"));  //Dbsecurity.Decrypt(Data.UserId), Dbsecurity.Decrypt(Data.EntityId)
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> GetUMRN(RequestFields Data)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_FrontUnProcessedMandate]").With<BindFields>().Execute("@QueryType", "@UserId", "@EntityId", "GetUMRN", "2", "2"));  //Dbsecurity.Decrypt(Data.UserId), Dbsecurity.Decrypt(Data.EntityId)
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> GetResponse(RequestFields Data)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_FrontUnProcessedMandate]").With<BindFields>().Execute("@QueryType", "@UserId", "@EntityId", "GetResponse", "2", "2"));  //Dbsecurity.Decrypt(Data.UserId), Dbsecurity.Decrypt(Data.EntityId)
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}