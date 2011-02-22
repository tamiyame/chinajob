using System;
using System.Collections.Generic;

using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB
{
    public class ConnectionString : IConnectionString
    {
        public string GetConnectionString()
        {
            return "server=chinajob.cafe24.com; uid=chinajob; pwd=dnpqel78; database=chinajob;";
        }
    }
}
