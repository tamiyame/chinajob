using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class SubCategoryGetInfo : DBDataReader<DataEntity, SubCategoryEntity>
    {
        public SubCategoryGetInfo()
            : base(new ConnectionString(), "TSP_SubCategoryGetInfo")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("SubCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("SubCategoryKRName", SqlDbType.NVarChar, 800, SqlDataInOut.Output);
            AddParameter("SubCategoryCNName", SqlDbType.NVarChar, 800, SqlDataInOut.Output);
            AddParameter("SubCategoryENGName", SqlDbType.NVarChar, 800, SqlDataInOut.Output);
        }
    }
}