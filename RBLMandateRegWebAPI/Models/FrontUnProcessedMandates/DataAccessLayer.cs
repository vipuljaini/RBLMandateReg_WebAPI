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
    }
}