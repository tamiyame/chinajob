using System.Data;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
	public class ResumeLanguageGetList : DBDataReader<ResumeLanguageEntity, DataEntity>
	{
		public ResumeLanguageGetList()
			: base(new ConnectionString(), "TSP_ResumeLanguageGetList")
		{
		}

		protected override void ParameterInitialize()
		{
			AddParameter("UserNo", SqlDbType.Int, 4, SqlDataInOut.Input);
			AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
		}
	}
}