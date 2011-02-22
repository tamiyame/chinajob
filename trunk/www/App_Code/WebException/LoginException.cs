using System;
using System.Data;
using System.Configuration;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

using Com.Framework.Error;

namespace Site.Web.WebException
{
    public class LoginException : BaseException
    {
        private string m_Message = string.Empty;
        public LoginException(string message, Exception innerException)
            : base(message, innerException)
        {
            m_Message = message;
            Notify();
        }

        public override void Notify()
        {
            if (HttpContext.Current != null)
            {
                HttpResponse res = System.Web.HttpContext.Current.Response;
                res.Clear();
                res.Write("<script language='javascript'>history.go(-1);alert('" + m_Message + "');</script>");
                res.End();
            }
        }
    }

    public class UserIDNotFoundException : LoginException
    {
        public UserIDNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    public class UserPWDException : LoginException
    {
        public UserPWDException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}


