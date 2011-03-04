using System.Data;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
    public class ResumeDetailCreate : DBDataReader<DataEntity, DataEntity>
    {
        public ResumeDetailCreate()
            : base(new ConnectionString(), "TSP_ResumeDetailCreate")
        {
        }

        protected override void ParameterInitialize()
        {
			AddParameter("UserNo", SqlDbType.Int, 4, SqlDataInOut.Input);
			AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
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
            AddParameter("ResumeDetailNo", SqlDbType.Int, 4, SqlDataInOut.Output);
        }
    }
}