using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.User
{
	public class ResumeModify : DBDataReader<DataEntity, DataEntity>
	{
		public ResumeModify()
            : base(new ConnectionString(), "TSP_ResumeModify")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("UserNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CompanyNo1", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CompanyNo2", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CompanyNo3", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("HopeSalary", SqlDbType.VarChar, 20, SqlDataInOut.Input);
            AddParameter("CityNo1", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("ArrayNo1", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("CityNo2", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("ArrayNo2", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("HopeRecruitDate", SqlDbType.DateTime, 8, SqlDataInOut.Input);
            AddParameter("BusinessCategoryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Category1No", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("Category2No", SqlDbType.Int, 4, SqlDataInOut.Input);
			AddParameter("JoinType", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
			AddParameter("RegistryTime", SqlDbType.DateTime, 8, SqlDataInOut.Input);
			AddParameter("Status", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
		}
	}
}
