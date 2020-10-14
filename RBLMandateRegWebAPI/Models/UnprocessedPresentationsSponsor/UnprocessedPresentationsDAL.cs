﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntityDAL;
using BusinessLibrary;
using Encryptions;
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
                var results = Common.Getdata(dbcontext.MultipleResults("[dbo].[TEMPDESTPRESENT]").With<GridDataTable>()
                          .Execute("@Querytype", "@EntityId", "@UserId", "BindHeaderGrid_Sponsor", Dbsecurity.Decrypt(data.EntityId), Dbsecurity.Decrypt(data.UserId)));
                return results;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}