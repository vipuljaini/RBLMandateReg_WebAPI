using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntityDAL;
using BusinessLibrary;
using Encryptions;
using System.IO;
using RBLMandateRegWebAPI.Models.UnprocessedPresentationsSponsor;

namespace RBLMandateRegWebAPI.Models.UnprocessedPresentationsSponsor
{
    public class UnprocessedPresentationsDAL
    {
        QuickCheck_AngularEntities dbcontext = new QuickCheck_AngularEntities();

        public Dictionary<string, object> BindHeaderGrid(UserDetails data)
        {

            try
            {
                var results = Common.Getdata(dbcontext.MultipleResults("[dbo].[TEMPDESTPRESENT_Sponsor]").With<GridDataTable>()
                          .Execute("@Querytype", "@Status", "@EntityId", "@UserId", "BindHeaderGrid_Sponsor",data.status, Dbsecurity.Decrypt(data.EntityId), Dbsecurity.Decrypt(data.UserId)));
                return results;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<string, object> BindDetailsGrid(UserDetails data)
        {

            try
            {
                var results = Common.Getdata(dbcontext.MultipleResults("[dbo].[TEMPDESTPRESENT_Sponsor]").With<DataTable0>().With<DataTable1>().With<DataTable2>().With<DataTable3>()
                          .Execute("@Querytype", "@EntityId", "@UserId", "BindDetailsGrid_Sponsor", Dbsecurity.Decrypt(data.EntityId), Dbsecurity.Decrypt(data.UserId)));
                return results;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> SubmitActivityData(UserDetails data)
        {

            try
            {
                var results = Common.Getdata(dbcontext.MultipleResults("[dbo].[TEMPDESTPRESENT_Sponsor]").With<SubmitActivityData>()
                          .Execute("@Querytype", "@EntityId", "@UserId", "SubmitActivityData", Dbsecurity.Decrypt(data.EntityId), Dbsecurity.Decrypt(data.UserId)));
                return results;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> BindActivityDetails_grid(UserDetails data)
        {

            try
            {
                var results = Common.Getdata(dbcontext.MultipleResults("[dbo].[TEMPDESTPRESENT_Sponsor]").With<DataTable0>().Execute("@Querytype", "@EntityId", "@UserId", "BindActivityDetails_grid", Dbsecurity.Decrypt(data.EntityId), Dbsecurity.Decrypt(data.UserId)));
                return results;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<string, object> SubmitBank_click(UserDetails data)
        {

            try
            {
                var results = Common.Getdata(dbcontext.MultipleResults("[dbo].[TEMPDESTPRESENT_Sponsor]").With<SubmitActivityData>()
                          .Execute("@Querytype", "@EntityId", "@UserId", "SubmitBank_click", Dbsecurity.Decrypt(data.EntityId), Dbsecurity.Decrypt(data.UserId)));
                return results;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> GetStatus_click(UserDetails data)
        {

            try
            {
                var results = Common.Getdata(dbcontext.MultipleResults("[dbo].[TEMPDESTPRESENT_Sponsor]").With<SubmitActivityData>()
                          .Execute("@Querytype", "@EntityId", "@UserId", "GetStatus_click", Dbsecurity.Decrypt(data.EntityId), Dbsecurity.Decrypt(data.UserId)));
                return results;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}