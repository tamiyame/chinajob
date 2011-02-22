using System;
using System.Collections.Generic;

using System.Text;

// 메일발송 //
using System.Net.Mail;

namespace Com.Framework.Email
{
    public class SendEmail
    {
        private static string m_DefaultHost = "192.168.110.4";

        public void Send(string fromAddr, string email, string subject, string contents)
        {
            
            MailMessage mail = new MailMessage();

            //메일 전송
            mail.From = new MailAddress(fromAddr);
            mail.To.Add(new MailAddress(email));

            mail.Subject = subject;
            mail.Body = contents;
            mail.BodyEncoding = System.Text.Encoding.UTF8;

            SmtpClient client = new SmtpClient();

            client.Host = m_DefaultHost;     //메일 서버 아이피 주소
            client.Port = 25;                               //메일 서버 포트 번호
            client.Send(mail);                              //메일 전송
        }
    }
}
