using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

using System.Web.Mail;
using Com.Library.DB.Company;
using Com.Library.DB.User;

namespace Site.Web.Soap
{
    /// <summary>
    /// User의 요약 설명입니다.
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    // ASP.NET AJAX를 사용하여 스크립트에서 이 웹 서비스를 호출하려면 다음 줄의 주석 처리를 제거합니다. 
    [System.Web.Script.Services.ScriptService]
    public class User : System.Web.Services.WebService
    {

        public User()
        {

            //디자인된 구성 요소를 사용하는 경우 다음 줄의 주석 처리를 제거합니다. 
            //InitializeComponent(); 
        }

        [WebMethod]
        public UserEntity IsUserID(string userID)
        {
            UserEntity userEntity = null;
            UserGetInfoArguments arg = new UserGetInfoArguments();
            arg.UserID = userID;
            UserGetInfo info = new UserGetInfo();
            info.SetArguments(arg);
            info.ExecuteNonQuery();
            userEntity = info.GetOutput();
            return userEntity ;
        }

        [WebMethod]
        public UserEntity IsEmail(string email)
        {
            UserEntity userEntity = null;
            UserGetInfoArguments arg = new UserGetInfoArguments();
            arg.Email = email;
            UserGetInfo info = new UserGetInfo();
            info.SetArguments(arg);
            info.ExecuteNonQuery();
            userEntity = info.GetOutput();
            return userEntity;
        }

        [WebMethod]
        public bool UserID_SendMail(byte userType, string email)
        {
            if (userType == 1)
            {
                CompanyDetailGetInfoArguments DetailArg = new CompanyDetailGetInfoArguments();
                DetailArg.Email = email;
                CompanyDetailGetInfo Detailinfo = new CompanyDetailGetInfo();
                Detailinfo.SetArguments(DetailArg);
                Detailinfo.ExecuteNonQuery();
                CompanyDetailEntity detailEntity = Detailinfo.GetOutput();

                if (detailEntity.CompanyNo == 0)
                {
                    return false;
                }

                CompanyGetInfoArguments ArgInfo = new CompanyGetInfoArguments();
                ArgInfo.CompanyNo = detailEntity.CompanyNo;
                CompanyGetInfo Info = new CompanyGetInfo();
                Info.SetArguments(ArgInfo);
                Info.ExecuteNonQuery();
                CompanyEntity Entity = Info.GetOutput();
                
                SendMail(Entity.CompanyID, detailEntity.ENGName, detailEntity.Email);
                return true;
            }
            else
            {
                UserEntity userEntity = null;
                UserGetInfoArguments arg = new UserGetInfoArguments();
                arg.Email = email;
                UserGetInfo info = new UserGetInfo();
                info.SetArguments(arg);
                info.ExecuteNonQuery();
                userEntity = info.GetOutput();

                SendMail(userEntity.UserID, userEntity.ENGName, email);

                return true;

            }
            return false;
        }

        [WebMethod]
        public bool UserPWD_SendMail(byte userType, string userid, string email)
        {
            if (userType == 1)
            {
                CompanyDetailGetInfoArguments DetailArg = new CompanyDetailGetInfoArguments();
                DetailArg.Email = email;
                CompanyDetailGetInfo Detailinfo = new CompanyDetailGetInfo();
                Detailinfo.SetArguments(DetailArg);
                Detailinfo.ExecuteNonQuery();
                CompanyDetailEntity detailEntity = Detailinfo.GetOutput();

                if (detailEntity.CompanyNo == 0)
                {
                    return false;
                }

                CompanyGetInfoArguments ArgInfo = new CompanyGetInfoArguments();
                ArgInfo.CompanyNo = detailEntity.CompanyNo;
                CompanyGetInfo Info = new CompanyGetInfo();
                Info.SetArguments(ArgInfo);
                Info.ExecuteNonQuery();
                CompanyEntity Entity = Info.GetOutput();

                if (Entity.CompanyID != userid)
                {
                    return false;
                }

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

                CompanyModifyArguments argModify = new CompanyModifyArguments();
                argModify.CompanyNo = detailEntity.CompanyNo;
                argModify.Password = password;
                CompanyModify modify = new CompanyModify();
                modify.SetArguments(argModify);
                modify.ExecuteNonQuery();

                SendMail(Entity.CompanyID, detailEntity.ENGName, detailEntity.Email, password);
                SendMail(Entity.CompanyID, detailEntity.ENGName, "master@chinajobgo.com", password);
                return true;
            }
            else
            {
                UserEntity userEntity = null;
                UserGetInfoArguments arg = new UserGetInfoArguments();
                arg.Email = email;
                UserGetInfo info = new UserGetInfo();
                info.SetArguments(arg);
                info.ExecuteNonQuery();
                userEntity = info.GetOutput();

                if (userEntity.UserNo == 0)
                {
                    return false;
                }

                if (userEntity.UserID != userid)
                {
                    return false;
                }

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

                UserModifyArguments argModify = new UserModifyArguments();
                argModify.UserNo = userEntity.UserNo;
                argModify.UserPWD = password;
                UserModify modify = new UserModify();
                modify.SetArguments(argModify);
                modify.ExecuteNonQuery();

                SendMail(userid, userEntity.ENGName, email, password);
                return true;

            }
        }

        private void SendMail(string userID, string name, string email)
        {
            string body = string.Empty;
            body += "<div style=font-family:tahoma;font-size:9pt>";
            body += "<p>This response is about your request form <a href=http://www.chinajobgo.com target=_blank>ChinaJobGo.com</a></p>";
            body += "<p>Thanks</p>";
            body += "<hr>";
            body += "<ul>";
            body += "<li>Email : " + email + "</li>";
	        body += "<li>Name : " + name + "</li>";
	        body += "<li>ID : <b><font color=#0f85f2>" + userID + "</font></b></li>";
            body += "</ul>";
            body += "<hr>";
            body += "</div>";

            MailMessage mail = new MailMessage();
            mail.From = "help@chinajobgo.com";
            mail.To = email;
            mail.Subject = "[ChinaJobGo] Your Request";
            mail.Body = body;
            mail.BodyFormat = MailFormat.Html;

            mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1"); //basic authentication 
            mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "help@chinajobgo.com"); //set your username here 
            mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "chinajob1212"); //set your password here 

            SmtpMail.SmtpServer = "mw-002.cafe24.com"; //your real server goes here 
            SmtpMail.Send(mail); 
        }


        private void SendMail(string userID, string name, string email, string password)
        {
            string body = string.Empty;
            body += "<div style=font-family:tahoma;font-size:9pt>";
            body += "<p>This response is about your request form <a href=http://www.chinajobgo.com target=_blank>ChinaJobGo.com</a></p>";
            body += "<p>Thanks</p>";
            body += "<hr>";
            body += "<ul>";
	        body += "<li>Email : " + email + "</li>";
            body += "<li>Name : " + name + "</li>";
	        body += "<li>ID : " + userID + "</li>";
	        body += "<li>Password : <b><font color=#0f85f2>" + password + "</font></b></li>";
            body += "</ul>";
            body += "<hr>";
            body += "<font color=#ff0000>Warning : Please change your PASSWORD after login</font>";
            body += "</div>";

            MailMessage mail = new MailMessage();
            mail.From = "help@chinajobgo.com";
            mail.To = email;
            mail.Subject = "[ChinaJobGo] Your Request";
            mail.Body = body;
            mail.BodyFormat = MailFormat.Html;

            mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1"); //basic authentication 
            mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "help@chinajobgo.com"); //set your username here 
            mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "chinajob1212"); //set your password here 

            SmtpMail.SmtpServer = "mw-002.cafe24.com"; //your real server goes here 
            SmtpMail.Send(mail);
        }
    }
}