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
