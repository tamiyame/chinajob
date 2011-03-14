using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.User
{
	public class ResumeDetailModify : DBDataReader<DataEntity, DataEntity>
	{
		public ResumeDetailModify()
			: base(new ConnectionString(), "TSP_ResumeDetailModify")
		{
		}

		protected override void ParameterInitialize()
		{
			AddParameter("UserNo", SqlDbType.Int, 4, SqlDataInOut.Input);
			AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
			AddParameter("ResumeDetailNo", SqlDbType.Int, 4, SqlDataInOut.Input);
			AddParameter("SSN1", SqlDbType.VarChar, 6, SqlDataInOut.Input);
			AddParameter("SSN2", SqlDbType.VarChar, 7, SqlDataInOut.Input);
			AddParameter("KoreanAge", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
			AddParameter("Age", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
			AddParameter("ChinaExp", SqlDbType.NVarChar, 40, SqlDataInOut.Input);
			AddParameter("Military", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
			AddParameter("IsCareer", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
			AddParameter("Address", SqlDbType.NVarChar, 400, SqlDataInOut.Input);
			AddParameter("Description", SqlDbType.NVarChar, -1, SqlDataInOut.Input);
			AddParameter("AboutMe", SqlDbType.NVarChar, -1, SqlDataInOut.Input);
			AddParameter("LastestEducation", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
			AddParameter("GraduationYear", SqlDbType.NVarChar, 50, SqlDataInOut.Input);
			AddParameter("MilitaryService", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
		}
	}
}