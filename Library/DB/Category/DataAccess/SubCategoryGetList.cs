using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Category
{
    public class SubCategoryGetList : DBDataReader<SubCategoryEntity, OutputEntity>
    {
        public SubCategoryGetList()
            : base(new ConnectionString(), "TSP_SubCategoryGetList")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}