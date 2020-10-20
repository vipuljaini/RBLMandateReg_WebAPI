using BusinessLibrary;
using EntityDAL;
using RBLMandateRegWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Reflection;
using System.Data;
using Encryptions;
using RBLMandateRegWebAPI.Controllers.BussinessLogicBIBE;

namespace RBLMandateRegWebAPI.Controllers
{
    public class BulkImageExcelReceivingApprovalController : ApiController
    {
        BIBEDAL obj = new BIBEDAL();

        [HttpPost]
        [Route("api/BIBETemp/BindDetails/")]
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
        [Route("api/BIBETemp/SentToChecker/")]
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
        [Route("api/BIBETemp/Approve/")]
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
        [Route("api/BIBETemp/ActivityCompleted/")]
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
        [Route("api/BIBETemp/Accept/")]
        public Dictionary<string, object> Accept()
        {
            try
            {
                return obj.Accept();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpPost]
        [Route("api/BIBETemp/Reject/")]
        public Dictionary<string, object> Reject()
        {
            try
            {
                return obj.Reject();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("api/BIBETemp/IsSave/")]
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
        [Route("api/BIBETemp/IsSentToChecker/")]
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
        [Route("api/BIBETemp/IsApprove/")]
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



        [HttpPost]
        [Route("api/BulkImageExcelReceivingApproval/FetchData")]
        public BulkImageExcelReceivingApprovalModallist FetchData(BulkImageExcelReceivingApprovalModal Acdata)
        {
            try
            {

                BulkImageExcelReceivingApprovalModallist res = new BulkImageExcelReceivingApprovalModallist();
                QuickCheck_AngularEntities dbcontext = new QuickCheck_AngularEntities();
                var Result = dbcontext.MultipleResults("sp_Temp_BulkImageExcelReceivingApproval").With<BulkImageExcelReceivingApprovalModal>().Execute("@QueryType", "FetchData");
                res.BulkImageExcelReceivingApprovalModalList = Result[0].Cast<BulkImageExcelReceivingApprovalModal>().ToList();
                return res;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        [HttpPost]
        [Route("api/BulkImageExcelReceivingApproval/GetMandateData/{ID}")]
        public Dictionary<string, object> GetMandateData(string ID)
        {

            try
            {
                List<GetMandateData> Gridlist = new List<GetMandateData>();
                QuickCheck_AngularEntities dbcontext = new QuickCheck_AngularEntities();               

                var results = dbcontext.MultipleResults("[dbo].[sp_Temp_BulkImageExcelReceivingApproval]").With<GetMandateData>()
                          .Execute("@Querytype", "@BIBE_Count", "GetMandateData", ID);
                Gridlist = results[0].Cast<GetMandateData>().ToList();
                DataTable dt = new DataTable();
                dt = ToDataTable(Gridlist);
                //foreach (DataRow row in dt.Rows)
                //{
                //    row["BankACNumber"] = Dbsecurity.Decrypt(Convert.ToString(row["AcNo"]));
                //    row["Amount"] = Dbsecurity.Decrypt(Convert.ToString(row["AmountRupees"]));
                //    row["PhoneNumber"] = Dbsecurity.Decrypt(Convert.ToString(row["PhoneNumber"]));
                //    row["EmailID"] = Dbsecurity.Decrypt(Convert.ToString(row["EmailId"]));

                //}
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                return ClsJson.JsonMethods.ToJson(ds);
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties by using reflection   
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names  
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {

                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

    }
}
