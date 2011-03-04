using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.User
{
	public class ResumeLicenseGetList : DBDataReader<ResumeLicenseEntity, DataEntity>
	{
		public ResumeLicenseGetList()
			: base(new ConnectionString(), "TSP_ResumeLicenseGetList")
		{
		}

		protected override void ParameterInitialize()
		{
			AddParameter("UserNo", SqlDbType.Int, 4, SqlDataInOut.Input);
			AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
		}
	}
}