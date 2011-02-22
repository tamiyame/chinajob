using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Banner
{
    public class BannerGetList : DBDataReader<BannerEntity, OutputEntity>
    {
        public BannerGetList()
            : base(new ConnectionString(), "TSP_BannerGetList")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("PageNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("PageSize", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("CntRow", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("CntTotal", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("BannerType", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("IsOperation", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}