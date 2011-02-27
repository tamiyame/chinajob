using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class CategoryModify : DBDataReader<DataEntity, DataEntity>
    {
        public CategoryModify()
            : base(new ConnectionString(), "TSP_CategoryModify")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CategoryMasterNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CategoryKRName", SqlDbType.NVarChar, 400, SqlDataInOut.Input);
            AddParameter("CategoryCNName", SqlDbType.NVarChar, 400, SqlDataInOut.Input);
            AddParameter("CategoryENGName", SqlDbType.NVarChar, 400, SqlDataInOut.Input);
            AddParameter("RecruitCount", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}