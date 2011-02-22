using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Banner
{
    public class BannerCreate : DBDataReader<BannerEntity, BannerEntity>
    {
        public BannerCreate()
            : base(new ConnectionString(), "TSP_BannerCreate")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("BannerType", SqlDbType.TinyInt, 1, SqlDataInOut.Input);
            AddParameter("LargeImageURL", SqlDbType.VarChar, 200, SqlDataInOut.Input);
            AddParameter("SmallImageUrl", SqlDbType.VarChar, 200, SqlDataInOut.Input);
            AddParameter("Link", SqlDbType.VarChar, 100, SqlDataInOut.Input);
            AddParameter("DateCreated", SqlDbType.DateTime, 8, SqlDataInOut.Input);
            AddParameter("OrderNo", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}