using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;
/// <summary>
/// Summary description for emailsender
/// </summary>
public class emailsender
{
    public emailsender(string to,string subject,string body)
    {
        MailMessage mail = new MailMessage();
        mail.To.Add(to);
        mail.From = new MailAddress("ur mail@gmail.com");
        mail.Subject = subject;
        mail.Body = body;
        mail.IsBodyHtml = true;

        SmtpClient smtp = new SmtpClient();
        smtp.Port = 587; // 25 465
        smtp.EnableSsl = true;
        smtp.UseDefaultCredentials = false;
        smtp.Host = "smtp.gmail.com";
        smtp.Credentials = new System.Net.NetworkCredential("ur mail", "app password");
        smtp.Send(mail);
    }
}
