using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.Banner
{
    public class BannerRemove : DBDataReader<BannerEntity, BannerEntity>
    {
        public BannerRemove()
            : base(new ConnectionString(), "TSP_BannerRemove")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("BannerNo", SqlDbType.Int, 4, SqlDataInOut.Input);
        }
    }
}