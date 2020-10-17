using BusinessLibrary;
using EntityDAL;
using System;
using System.Collections.Generic;
using static RBLMandateRegWebAPI.Models.NPCIUnProcessMandate;

namespace RBLMandateRegWebAPI.Models
{
    public class NPCIUnProcessMandateDAL
    {
        //public Dictionary<string, object> BindGrid(GetDatavalue obj)
        //{
        //    QuickCheck_AngularEntities dbcontext = new QuickCheck_AngularEntities();
        //    try
        //    {
        //        var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_NPCIUnprocessedMandates]").With<GridBind>()
        //        .Execute("@QueryType", "@AppId", "BindGrid", obj.AppId));
        //        return Result;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public Dictionary<string, object> BindNpciApprovalProcessGrid(GetDatavalue obj)
        //{
        //    QuickCheck_AngularEntities dbcontext = new QuickCheck_AngularEntities();
        //    try
        //    {
        //        var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_NPCIUnprocessedMandates]").With<GridBind1>()
        //        .Execute("@QueryType", "@AppId", "Bindnpciapprovalprocess", obj.AppId));
        //        return Result;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}