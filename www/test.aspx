<%@ Page Language="C#" AutoEventWireup="true" CodeFile="test.aspx.cs" Inherits="test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>제목 없음</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
<%
    string tmpPassword = "abcdefghijklmnopqrstuvwxyz1234567890";
    string password = "";
    System.Random rnd = new Random(DateTime.Now.Millisecond);
    for (int i = 0; i < 7; i++)
    {
        int idx = rnd.Next(0, tmpPassword.Length);
        if (idx < tmpPassword.Length)
        {
            password += tmpPassword.Substring(idx, 1);
        }
    }
    Response.Write(password);
 %>
    </div>
    </form>
</body>
</html>
