using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotbookCommand
{
    public static class DBInfo
    {
        public static string GetConnectionString()
        {
            string retValue = string.Empty;
            string fileName = @".\connection.info";
            FileInfo fi = new FileInfo(fileName);
            if (fi.Exists)
            {
                StreamReader sr = new StreamReader(fileName);
                if (!sr.EndOfStream)
                {
                    retValue = sr.ReadLine();
                }
                sr.Close();
                sr.Dispose();
                sr = null;
            }
            return retValue;
        }

        public static DataSet GetTableList()
        {

            string connection = GetConnectionString();
            if (connection != string.Empty)
            {
                SqlConnection conn = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sp_tables";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("table_owner", "dbo"));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                conn.Open();
                da.Fill(ds);
                conn.Close();
                return ds;
            }
            return null;
        }

        public static DataSet GetFieldList(string tableName)
        {
            string connection = GetConnectionString();
            if (connection != string.Empty)
            {
                SqlConnection conn = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format(@"SELECT
      c.name, --FIELD
      t.name AS typename, -- TYPE
      c.max_length AS length, -- SIZE
      c.is_nullable, -- NULL / NOT NULL
      c.is_identity, -- Identity Yes/No
      convert( bit, case when index_col( '{0}', 1, column_id ) is not null then 1 else 0 end ) is_primary  -- primary Yes/No
FROM sys.columns c
     INNER JOIN sys.types t ON c.user_type_id = t.user_type_id
     INNER JOIN sys.objects tb ON tb.object_id = c.object_id
     INNER JOIN sys.schemas u ON u.schema_id = tb.schema_id
WHERE tb.name = '{0}' AND u.name = 'dbo'
ORDER BY c.column_id", tableName);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                conn.Open();
                da.Fill(ds);
                conn.Close();
                return ds;
            }
            return null;
        }

        public static string ReplaceToC(string sqlType)
        {
            string retValue = "string";
            switch (sqlType.ToLower().Trim())
            {
                case "varchar": retValue = "string"; break;
                case "binary": retValue = "string"; break;
                case "nvarchar": retValue = "string"; break;
                case "ntext": retValue = "string"; break;
                case "text": retValue = "string"; break;
                case "int": retValue = "int"; break;
                case "smallint": retValue = "short"; break;
                case "tinyint": retValue = "byte"; break;
                case "bigint": retValue = "long"; break;
                case "float": retValue = "double"; break;
                case "real": retValue = "double"; break;
                case "datetime": retValue = "DateTime"; break;
                case "smalldatetime": retValue = "DateTime"; break;
            }

            return retValue;
        }

        public static string DefaultValue(string cType)
        {
            string retValue = "string.Empty";
            switch (cType.ToLower().Trim())
            {
                case "string": retValue = "string.Empty"; break;
                case "int": retValue = "(int)0"; break;
                case "short": retValue = "(short)0"; break;
                case "byte": retValue = "(byte)0"; break;
                case "long": retValue = "(long)0"; break;
                case "double": retValue = "(double)0"; break;
                case "datetime": retValue = "DateTime.MinValue"; break;
            }
            
            return retValue;
        }

        public static string ConvertC(string cType)
        {
            string retValue = "string.Empty";
            switch (cType.ToLower().Trim())
            {
                case "string": retValue = "Convert.ToString"; break;
                case "int": retValue = "Convert.ToInt32"; break;
                case "short": retValue = "Convert.ToInt16"; break;
                case "byte": retValue = "Convert.ToByte"; break;
                case "long": retValue = "Convert.ToInt64"; break;
                case "double": retValue = "Convert.ToDouble"; break;
                case "datetime": retValue = "Convert.ToDateTime"; break;
            }

            return retValue;
        }
    }
}
