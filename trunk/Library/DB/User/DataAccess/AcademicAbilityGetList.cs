using System.Data;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
	public class ResumeAcademicAbilityGetList : DBDataReader<ResumeAcademicAbilityEntity, DataEntity>
	{
		public ResumeAcademicAbilityGetList()
			: base(new ConnectionString(), "TSP_ResumeAcademicAbilityGetList")
		{
		}

		protected override void ParameterInitialize()
		{
			AddParameter("UserNo", SqlDbType.Int, 4, SqlDataInOut.Input);
			AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
		}
	}
}