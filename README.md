Sending Email in ASP.NET Using SMTP
This code snippet demonstrates how to send an email using the SMTP protocol in an ASP.NET application. It uses Gmail's email server to send the email.

# Requirements
An SMTP-enabled email account. In this case, Gmail is used.
An ASP.NET application.
# Instructions
1) Copy the code below into a class called "emailsender" in your ASP.NET application code. This class contains the method that sends the email.
```csharp
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
```
2) To send an email, use the code below and replace the placeholders with the email address, subject, and body of the email you want to send.
```csharp
string to = "recipient@example.com";
string subject = "Message from your website from John Doe";
string body = "Hello,\n\nThis is a test message sent from my website.\n\nThanks,\nJohn Doe";
emailsender send = new emailsender(to, subject, body);
```
Note: Make sure to replace "ur mail" and "app password" with your actual Gmail email and password. Additionally, you may need to enable "less secure apps" in your Gmail account settings to allow this code to send emails.
By following these instructions, you can use this code snippet to easily send emails from your ASP.NET application using SMTP.
