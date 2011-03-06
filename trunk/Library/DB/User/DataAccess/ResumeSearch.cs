using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.User
{
    public class ResumeSearch : DBDataReader<ResumeSearchEntity, OutputEntity>
    {
        public ResumeSearch()
            : base(new ConnectionString(), "TSP_ResumeSearch")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("UserName", SqlDbType.NVarChar, 50, SqlDataInOut.Input);
            AddParameter("JoinType", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("Category1No", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Category2No", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CityCategory", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("AreaCategory", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Age_Start", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Age_End", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Gender", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("PageNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("PageSize", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("CntRow", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("CntTotal", SqlDbType.Int, 4, SqlDataInOut.Output);
        }
    }
}