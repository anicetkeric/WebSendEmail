using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace WebSendEmail
{
    public class utils
    {

        public static string SendMail(Email email)
        {
            string from = GmailSmtp.sender;
            MailMessage message = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            string msg = string.Empty;
            try
            {
                MailAddress fromAddress = new MailAddress(from);
                message.From = fromAddress;
                message.To.Add(email.toList);
                if (email.ccList != null && email.ccList != string.Empty)
                    message.CC.Add(email.ccList);
                message.Subject = email.subject;
                message.IsBodyHtml = true;
                message.Body = String.Format("<html><head></head><body><div>{0}</div></body></html>", email.body);
                smtpClient.Host = GmailSmtp.smtpAddress;   // We use gmail as our smtp client
                smtpClient.Port = GmailSmtp.portNumber;
                smtpClient.EnableSsl = GmailSmtp.enableSSL;
                smtpClient.UseDefaultCredentials = true;
                smtpClient.Credentials = new System.Net.NetworkCredential(GmailSmtp.sender, GmailSmtp.password);

                smtpClient.Send(message);

                msg = "1";
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }
    }
}