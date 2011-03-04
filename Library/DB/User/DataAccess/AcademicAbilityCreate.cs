using System.Data;
using Com.Framework.Data;

namespace Com.Library.DB.User
{
    public class ResumeAcademicAbilityCreate : DBDataReader<DataEntity, DataEntity>
    {
        public ResumeAcademicAbilityCreate()
            : base(new ConnectionString(), "TSP_ResumeAcademicAbilityCreate")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("UserNo", SqlDbType.Int, 4, SqlDataInOut.Input);
			AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
			AddParameter("SchoolName", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
            AddParameter("SchoolStartDate", SqlDbType.DateTime, 8, SqlDataInOut.Input);
            AddParameter("SchoolEndDate", SqlDbType.DateTime, 8, SqlDataInOut.Input);
            AddParameter("SchoolStatus", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("MajorMinor", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
            AddParameter("SchoolCountryName", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
            AddParameter("ResumeAcademicAbilityNo", SqlDbType.Int, 4, SqlDataInOut.Output);
        }
    }
}