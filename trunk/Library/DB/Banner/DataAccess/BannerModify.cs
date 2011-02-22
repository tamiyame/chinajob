using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Banner
{
    public class BannerModify : DBDataReader<DataEntity, DataEntity>
    {
        public BannerModify()
            : base(new ConnectionString(), "TSP_BannerModify")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("BannerType", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("BannerNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("LargeImageURL", SqlDbType.VarChar, 200, SqlDataInOut.Input);
            AddParameter("SmallImageUrl", SqlDbType.VarChar, 200, SqlDataInOut.Input);
            AddParameter("Link", SqlDbType.VarChar, 100, SqlDataInOut.Input);
            AddParameter("OrderNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("IsView", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}