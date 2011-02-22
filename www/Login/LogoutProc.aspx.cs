using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using Com.Framework.Cookie;
using Com.Library.Cookie;

public partial class Login_LogoutProc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string Redirect = Server.UrlDecode(Request.Form["Redirect"]);
        if (Redirect == null)
        {
            Redirect = "/";
        }
        WebCookie cookie = new WebCookie();
        cookie.Clear();
        Response.Write("<script language='javascript'>location.href='" + Redirect + "';</script>");
    }
}
