using System.Data;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
	public class ResumeCareerModify : DBDataReader<DataEntity, DataEntity>
	{
		public ResumeCareerModify()
			: base(new ConnectionString(), "TSP_ResumeCareerModify")
		{
		}

		protected override void ParameterInitialize()
		{
			AddParameter("UserNo", SqlDbType.Int, 4, SqlDataInOut.Input);
			AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
			AddParameter("ResumeCareerNo", SqlDbType.Int, 4, SqlDataInOut.Input);
			AddParameter("CareerCompanyName", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
			AddParameter("CareerStartDate", SqlDbType.DateTime, 8, SqlDataInOut.Input);
			AddParameter("CareerEndDate", SqlDbType.DateTime, 8, SqlDataInOut.Input);
			AddParameter("CareerJobs", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
			AddParameter("CareerPosition", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
		}
	}
}