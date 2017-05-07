# WebSendEmail
send an Email using C# 



## Server Parameters

| Server Name        | SMTP Address |Port  | SSL
| ------------- |:-------------:| -----|-----|
| Yahoo!   | smtp.mail.yahoo.com |587 |Yes |
|Gmail      | smtp.gmail.com      |  587| Yes
| Hotmail| smtp.live.com     |  587 | Yes
| Outlook|smtp-mail.outlook.com      |   587 | Yes |

## main class

```c#
    public class Email
    {       
        public string toList { get; set; }
        public string ccList { get; set; }
        public string subject { get; set; }
        public string body { get; set; }

    }

    public class GmailSmtp
    {
        
        public static int portNumber = 587;
        public static string smtpAddress = "smtp.gmail.com";
        public static bool enableSSL = true;
        public static string sender = "<your_email>";
        public static string password = "<your_password>";

    }

    public class YahooSmtp
    {

        public static int portNumber = 587;
        public static string smtpAddress = "smtp.mail.yahoo.com";
        public static bool enableSSL = true;
        public static string sender = "<your_email>";
        public static string password = "<your_password>";

    }

    public class HotmailSmtp
    {

        public static int portNumber = 587;
        public static string smtpAddress = "smtp.live.com";
        public static bool enableSSL = true;
        public static string sender = "<your_email>";
        public static string password = "<your_password>";

    }

    public class OutlookSmtp
    {

        public static int portNumber = 587;
        public static string smtpAddress = "smtp-mail.outlook.com";
        public static bool enableSSL = true;
        public static string sender = "<your_email>";
        public static string password = "<your_password>";

    }
}

```

## SendMail method with gmail smtp
this method use gmail.smtp
```c#
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

```
