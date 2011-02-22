using System;
using System.Web;
using Com.Framework.Error;

namespace Com.Framework.Data
{
    public class DBExcetion : BaseException
	{
		private int m_errorcode = 0;
        private string m_message = string.Empty;
		public DBExcetion(int errorcode, string message, Exception innerException) : base( message, innerException )
		{
            this.m_message = message;
			this.m_errorcode = errorcode;
		}

		public DBExcetion(string message, Exception innerException) : base( message, innerException )
		{
            this.m_message = message;
		}

		public int ErrorCode
		{
			get { return this.m_errorcode; }
		}

        public override void Notify()
        {
            HttpResponse res = HttpContext.Current.Response;
            res.Write("<script language='javascript'>history.go(-1);alert('" + m_message + "');</script>");

        }
	}

	public class DBSystemException : DBExcetion
	{
		public DBSystemException(int errorcode, string message, Exception innerException) : base( errorcode, message, innerException )
		{
		}
	}

	public class SPException : DBExcetion
	{
		public SPException(int errorcode, string message, Exception innerException) : base( errorcode, message, innerException )
		{
		}
	}
}
