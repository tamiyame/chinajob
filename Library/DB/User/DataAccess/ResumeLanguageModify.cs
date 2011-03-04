using System.Data;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
	public class ResumeLanguageModify : DBDataReader<DataEntity, DataEntity>
	{
		public ResumeLanguageModify()
			: base(new ConnectionString(), "TSP_ResumeLanguageModify")
		{
		}

		protected override void ParameterInitialize()
		{
			AddParameter("UserNo", SqlDbType.Int, 4, SqlDataInOut.Input);
			AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
			AddParameter("ResumeLanguageNo", SqlDbType.Int, 4, SqlDataInOut.Input);
			AddParameter("LanguageName", SqlDbType.NVarChar, 40, SqlDataInOut.Input);
			AddParameter("TestDesc", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
			AddParameter("GradeDesc", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
			AddParameter("ConversationLevel", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
		}
	}
}