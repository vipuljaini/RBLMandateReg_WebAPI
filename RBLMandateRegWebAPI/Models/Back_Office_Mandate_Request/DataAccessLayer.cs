﻿using BusinessLibrary;
using EntityDAL;
using System;
using System.Collections.Generic;
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
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_RBL_BackOffice]").With<MandateRequestData>().Execute("@QueryType", "BindUnProcessGrid"));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}