using System.Data;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
	public class ResumeCareerGetList : DBDataReader<ResumeCareerEntity, DataEntity>
	{
		public ResumeCareerGetList()
			: base(new ConnectionString(), "TSP_ResumeCareerGetList")
		{
		}

		protected override void ParameterInitialize()
		{
			AddParameter("UserNo", SqlDbType.Int, 4, SqlDataInOut.Input);
			AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
		}
	}
}