using ClassLibraryProject.Class;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses
{
    public class EmailManager
    {
        public void Email(string Password, string Username, string Email)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("MediaBazaar.HQ@gmail.com", "MediaBazaar21"),
                    EnableSsl = true,
                };

                StringBuilder message = new StringBuilder();

                message.Append(" <h1>Here is your acount information.</h1>");
                message.AppendLine("<p>Here is your acount information.</p>");
                message.AppendLine("<p>You can use these in the diferent mediabazaar apps and websites.</p>");
                message.AppendLine($"<p>                Username: {Username}</p>");
                message.AppendLine($"<p>                password: {Password}</p>");
                message.AppendLine("<p> Please change your password on i474883core.venus.fhict.nl </p>");
                message.AppendLine("<p> Contact us with this email adress if you run in to any problems: nazibul.kabir.srv@gmail.com</p>");

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("MediaBazaar.HQ@gmail.com"),
                    Subject = "Mediabazaar acount information",
                    Body = message.ToString(),
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(Email);

                smtpClient.Send(mailMessage);
            }
            catch{ }
        }

        public void NewEmployeeInfoEmail(Employee e)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("mediabazaar.hq@gmail.com", "MediaBazaar21"),
                    EnableSsl = true,
                };

                StringBuilder message = new StringBuilder();

                message.Append("<h1>Welcome to Media Bazaar!</h1>");
                message.AppendLine("<h2>Here is your account information:</h2>");
                message.AppendLine("<p>You can use these credentials to log in to the different Media Bazaar apps and the website</p>");
                message.AppendLine($"<p>                username: {e.Username}</p>");
                message.AppendLine($"<p>                password: {e.Password}</p>");
                message.AppendLine($"<p>                email: {e.Email}</p>");
                message.AppendLine("<p>Please change your password on our website: i474883core.venus.fhict.nl</p>");
                message.AppendLine("<p>If you run into any problems please contact us at mediabazaar.hq@gmail.com</p>");

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("mediabazaar.hq@gmail.com"),
                    Subject = "Welcome to Media Bazaar!",
                    Body = message.ToString(),
                    IsBodyHtml = true,
                };

                mailMessage.To.Add(e.PersonalEmail);

                smtpClient.Send(mailMessage);
            }
            catch { }
        }
    }
}
