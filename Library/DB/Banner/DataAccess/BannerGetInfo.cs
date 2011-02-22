using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Banner
{
    public class BannerGetInfo : DBDataReader<BannerEntity, BannerEntity>
    {
        public BannerGetInfo()
            : base(new ConnectionString(), "TSP_BannerGetInfo")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("CountryNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("BannerType", SqlDbType.TinyInt, 1, SqlDataInOut.Output);
            AddParameter("BannerNo", SqlDbType.Int, 4, SqlDataInOut.InputOutput);
            AddParameter("LargeImageURL", SqlDbType.VarChar, 200, SqlDataInOut.Output);
            AddParameter("SmallImageUrl", SqlDbType.VarChar, 200, SqlDataInOut.Output);
            AddParameter("Link", SqlDbType.VarChar, 100, SqlDataInOut.Output);
            AddParameter("DateCreated", SqlDbType.DateTime, 8, SqlDataInOut.Output);
            AddParameter("OrderNo", SqlDbType.Int, 4, SqlDataInOut.Output);
            AddParameter("IsView", SqlDbType.Int, 4, SqlDataInOut.Output);
        }
    }
}