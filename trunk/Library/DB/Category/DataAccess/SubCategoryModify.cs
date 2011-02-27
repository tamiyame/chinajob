using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class SubCategoryModify : DBDataReader<DataEntity, DataEntity>
    {
        public SubCategoryModify()
            : base(new ConnectionString(), "TSP_SubCategoryModify")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("SubCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("SubCategoryKRName", SqlDbType.NVarChar, 800, SqlDataInOut.Input);
            AddParameter("SubCategoryCNName", SqlDbType.NVarChar, 800, SqlDataInOut.Input);
            AddParameter("SubCategoryENGName", SqlDbType.NVarChar, 800, SqlDataInOut.Input);
            AddParameter("RecruitCount", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}