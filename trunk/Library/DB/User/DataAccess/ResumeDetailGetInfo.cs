using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.User
{
	public class ResumeDetailGetInfo : DBDataReader<DataEntity, ResumeDetailEntity>
	{
		public ResumeDetailGetInfo()
			: base(new ConnectionString(), "TSP_ResumeDetailGetInfo")
		{
		}

		protected override void ParameterInitialize()
		{
			AddParameter("UserNo", SqlDbType.Int, 4, SqlDataInOut.Input);
			AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
			AddParameter("ResumeDetailNo", SqlDbType.Int, 4, SqlDataInOut.Output);
			AddParameter("SSN1", SqlDbType.VarChar, 6, SqlDataInOut.Output);
			AddParameter("KoreanAge", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
			AddParameter("Age", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
			AddParameter("ChinaExp", SqlDbType.NVarChar, 40, SqlDataInOut.Output);
			AddParameter("Military", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
			AddParameter("IsCareer", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
			AddParameter("Address", SqlDbType.NVarChar, 400, SqlDataInOut.Output);
			AddParameter("Description", SqlDbType.NVarChar, -1, SqlDataInOut.Output);
			AddParameter("AboutMe", SqlDbType.NVarChar, -1, SqlDataInOut.Output);
		}
	}
}