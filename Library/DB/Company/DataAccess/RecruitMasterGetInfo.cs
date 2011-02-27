﻿using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Company
{
    public class RecruitMasterGetInfo : DBDataReader<DataEntity, DataEntity>
    {
        public RecruitMasterGetInfo()
            : base(new ConnectionString(), "TSP_RecruitMasterGetInfo")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CompanyNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("RecruitNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("RecruitTitle", SqlDbType.NVarChar, 200, SqlDataInOut.Output);
            AddParameter("DateCreated", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("ParticipateTotalCount", SqlDbType.Int, 4, SqlDataInOut.Output);
        }
    }
}