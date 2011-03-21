using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.User
{
    public class ResumeGetList : DBDataReader<ResumeEntity, DataEntity>
    {
        public ResumeGetList()
            : base(new ConnectionString(), "TSP_ResumeGetList")
        {
        }

        protected override void ParameterInitialize()
        {
        }

    }
}