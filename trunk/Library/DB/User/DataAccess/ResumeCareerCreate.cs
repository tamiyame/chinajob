using System.Data;

using Com.Framework.Data;

namespace Com.Library.DB.User
{
    public class ResumeCareerCreate : DBDataReader<DataEntity, DataEntity>
    {
        public ResumeCareerCreate()
            : base(new ConnectionString(), "TSP_ResumeCareerCreate")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("UserNo", SqlDbType.Int, 4, SqlDataInOut.Input);
			AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
			AddParameter("CareerCompanyName", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
			AddParameter("CareerStartDate", SqlDbType.NVarChar, 10, SqlDataInOut.Input);
			AddParameter("CareerEndDate", SqlDbType.NVarChar, 10, SqlDataInOut.Input);
            AddParameter("CareerJobs", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
            AddParameter("CareerPosition", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
			AddParameter("CareerLocation", SqlDbType.NVarChar, 100, SqlDataInOut.Input);
			AddParameter("ResumeCareerNo", SqlDbType.Int, 4, SqlDataInOut.Output);
		}
    }
}