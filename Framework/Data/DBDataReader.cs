using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Com.Framework.Data
{
    public abstract class DBDataReader<R, P> : DBDataHelper
        where R : DataEntity, new()
        where P : DataEntity, new()
    {

        private List<R> m_Records = null;
        private P m_OutputParam = null;
        private DataSet m_DataSet = null;
        private SqlDataAdapter SQLDataAdapter = null;
        public DBDataReader(IConnectionString DBconn, string strStoreProcedure)
            : base(DBconn, strStoreProcedure)
        {
        }

        protected abstract void ParameterInitialize();

        private void OutputParameterOpen()
        {
            if (m_OutputParam == null)
            {
                m_OutputParam = new P();
            }


            foreach (SqlParameter param in SQLCommand.Parameters)
            {
                if (param.Direction != ParameterDirection.ReturnValue && param.Direction != ParameterDirection.Input)
                {
                    m_OutputParam.SetData(param.ParameterName.Replace("@", ""), param.Value);
                }
            }
        }

        protected override void SQLParameterInitialize()
        {
            base.SQLParameterInitialize();
            this.ParameterInitialize();
        }

        public List<R> Execute()
        {
            Exception exDB = null;
            int ErrorCode = 0;
            string ErrorMessage = string.Empty;
            m_DataSet = new DataSet();
            SQLDataAdapter = new SqlDataAdapter();
            DBInitialize(); 
            try
            {
                SQLDataAdapter.SelectCommand = this.SQLCommand;
                SQLDataAdapter.Fill(m_DataSet, this.StoreProcedureName);
                this.OutputParameterOpen();
                SQLDataAdapter.Dispose();
                SQLDataAdapter = null;
                ErrorCode = Convert.ToInt32(m_OutputParam.GetData("ErrorCode", 0));
                ErrorMessage = m_OutputParam.GetData("ErrorMessage", string.Empty).ToString();
            }
            catch (Exception ex)
            {
                m_DataSet = null;
                exDB = ex;
            }
            finally
            {
                this.DBConnectionClosing();
            }
            if (exDB != null)
            {
                throw new DBSystemException(100, exDB.Message, exDB);
            }
            if (ErrorCode != 0)
            {
                throw new SPException(ErrorCode, ErrorMessage, null);
            }

            LastExecute();

            m_Records = GetRecords();
            return m_Records;
        }

        public P ExecuteNonQuery()
        {
            int ErrorCode = 0;
            string ErrorMessage = string.Empty;
            Exception exDB = null;
            SQLDataAdapter = new SqlDataAdapter();
            DBInitialize();
            try
            {
                this.SQLCommand.ExecuteNonQuery();
                this.OutputParameterOpen();
                ErrorCode = Convert.ToInt32(m_OutputParam.GetData("ErrorCode", 0));
                ErrorMessage = m_OutputParam.GetData("ErrorMessage", string.Empty).ToString();
            }
            catch (Exception ex)
            {
                exDB = ex;
            }
            finally
            {
                this.DBConnectionClosing();
            }
            if (exDB != null)
            {
                throw new DBSystemException(100, exDB.Message, exDB);
            }
            if (ErrorCode != 0)
            {
                throw new SPException(ErrorCode, ErrorMessage, null);
            }

            LastExecute();
            return m_OutputParam;
        }

        public List<R> GetRecords()
        {
            if (m_Records != null)
            {
                return m_Records;
            }

            if (m_Records == null)
            {
                m_Records = new List<R>();
            }
            if (m_DataSet != null)
            {
                if (m_DataSet.Tables.Count > 0)
                {
                    foreach (DataRow row in m_DataSet.Tables[0].Rows)
                    {
                        R rowData = new R();
                        foreach (DataColumn col in m_DataSet.Tables[0].Columns)
                        {
                            rowData.SetData(col.ColumnName, row[col.ColumnName]);
                        }
                        m_Records.Add(rowData);
                    }
                }
            }

            return m_Records;
        }

        public P GetOutput()
        {
            return m_OutputParam;
        }

        protected override void DBConnectionClosing()
        {
            if (SQLDataAdapter != null)
            {
                SQLDataAdapter.Dispose();
                SQLDataAdapter = null;
            }

            if (this.SQLConnnection != null)
            {
                this.SQLConnnection.Close();
                this.SQLConnnection.Dispose();
                this.SQLConnnection = null;
            }

            if (this.SQLCommand != null)
            {
                this.SQLCommand.Dispose();
                this.SQLCommand = null;
            }
        }

        protected virtual void LastExecute()
        {
        }
    }
}
