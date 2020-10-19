using BusinessLibrary;
using EntityDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RBLMandateRegWebAPI.Models.CorporateRequest
{
    public class DataAccessLayer
    {
        QuickCheck_AngularEntities context = new QuickCheck_AngularEntities();


        public Dictionary<string, object> FetchData(RequestFields Data)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_CorporateRequest]").With<BindGridFields>().Execute("@QueryType", "@UserId", "@EntityId", "FetchData", "2", "2"));  //Dbsecurity.Decrypt(Data.UserId), Dbsecurity.Decrypt(Data.EntityId)
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> BindDetailGrid(RequestFields Data)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_CorporateRequest]").With<BindGridFields>().Execute("@QueryType", "@FileNo", "@UserId", "@EntityId", "BindDetailGrid",Data.FileNo, "2", "2"));  //Dbsecurity.Decrypt(Data.UserId), Dbsecurity.Decrypt(Data.EntityId)
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}