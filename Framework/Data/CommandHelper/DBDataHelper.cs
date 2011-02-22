using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Com.Framework.Data
{
    public enum SqlDataInOut
    {
        ReturnValue = 0,
        Input = 1,
        Output = 2,
        InputOutput = 3,
    }

    public abstract class DBDataHelper : Object
    {
        protected SqlConnection SQLConnnection = null;
        protected SqlCommand SQLCommand = null;
        protected IConnectionString DBconn = null;
        protected Hashtable m_htParam = null;
        //private SqlTransaction SQLTransaction = null;

        protected DBDataHelper(IConnectionString DBconn, string strStoreProcedure)
        {
            this.StoreProcedureName = strStoreProcedure;
            this.DBconn = DBconn;
            m_htParam = new Hashtable();
        }

        private string m_StoreProcedure = string.Empty;
        protected string StoreProcedureName
        {
            get { return this.m_StoreProcedure; }
            set { m_StoreProcedure = value; }
        }

        private int m_DBCommandTimeout = 3;
        protected int DBCommandTimeout
        {
            get { return this.m_DBCommandTimeout; }
            set { this.m_DBCommandTimeout = value; }
        }

        // DB 초기화
        protected void DBInitialize()
        {
            this.SQLConnnection = new SqlConnection(DBconn.GetConnectionString());
            this.SQLCommand = new SqlCommand();
            this.SQLCommand.CommandType = CommandType.StoredProcedure;
            this.SQLCommand.CommandText = this.StoreProcedureName;
            this.SQLCommand.CommandTimeout = this.DBCommandTimeout;
            this.SQLCommand.Connection = this.SQLConnnection;
            this.SQLParameterInitialize();
            this.SQLConnnection.Open();
        }


        // 파라미터 추가

        protected void ReturnValueParameter()
        {
            SetValue("IsTransaction", 1);

            this.AddParameter("RETURN_VALUE", SqlDbType.Int, 4, SqlDataInOut.ReturnValue);
            this.AddParameter("IsTransaction", SqlDbType.Int, 4, SqlDataInOut.Input);
            this.AddParameter("ErrorCode", SqlDbType.Int, 4, SqlDataInOut.Output);
            this.AddParameter("ErrorMessage", SqlDbType.NVarChar, 100, SqlDataInOut.Output);
        }

        protected virtual void SQLParameterInitialize()
        {
            this.ReturnValueParameter();
        }

        protected void AddParameter(string strName, SqlDbType SQLDbType, int n4Size, SqlDataInOut inout)
        {
            SqlParameter sqlParam = new SqlParameter();
            sqlParam.SqlDbType = SQLDbType;
            if (n4Size != 0)
            {
                sqlParam.Size = n4Size;
            }
            sqlParam.ParameterName = strName.IndexOf("@") == -1 ? "@" + strName : strName;
            switch (inout)
            {
                case SqlDataInOut.Input: sqlParam.Direction = ParameterDirection.Input; break;
                case SqlDataInOut.Output: sqlParam.Direction = ParameterDirection.Output; break;
                case SqlDataInOut.InputOutput: sqlParam.Direction = ParameterDirection.InputOutput; break;
                case SqlDataInOut.ReturnValue: sqlParam.Direction = ParameterDirection.ReturnValue; break;
                default: sqlParam.Direction = ParameterDirection.Input; break;
            }
            if (m_htParam.Contains(strName.ToUpper()))
            {
                sqlParam.Value = m_htParam[strName.ToUpper()];
            }

            SQLCommand.Parameters.Add(sqlParam);
        }

        protected void SetValue(string name, object value)
        {
            if ( m_htParam.ContainsKey( name.ToUpper() ) )
            {
                m_htParam[name.ToUpper()] = value;
            }
            else
            {
                m_htParam.Add(name.ToUpper(), value);
            }
        }

        protected object GetOutputParameter(string Name)
        {
            if (SQLCommand.Parameters.Contains("@" + Name))
            {
                SqlParameter sqlParam = SQLCommand.Parameters["@" + Name];
                if (sqlParam.Direction == ParameterDirection.Output || sqlParam.Direction == ParameterDirection.InputOutput || sqlParam.Direction == ParameterDirection.ReturnValue)
                    return SQLCommand.Parameters["@" + Name].Value;
            }
            return null;
        }
        
        public void SetArguments(IArguments arg)
        {
            Hashtable ht = arg.GetData();
            foreach (string key in ht.Keys)
            {
                SetValue(key.ToUpper(), ht[key]);
            }
        }

        // DB 종료될때 Open되어 있는 부분 모두 닫기
        protected abstract void DBConnectionClosing();
    }
}
