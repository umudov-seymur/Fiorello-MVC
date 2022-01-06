using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;

namespace Fiorello_MVC.Services
{
    public class EmailSender : IEmailSender
    {
        private EmailSenderOptions Options { get; set; }
        
        public EmailSender(IOptions<EmailSenderOptions> options)
        {
            Options = options.Value;
        }
        
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Execute(email, subject, message);
        }

        private async Task<bool> Execute(string email, string subject, string htmlMessage)
        {
            var mailMessage = new MimeMessage();
            mailMessage.From.Add(new MailboxAddress(Options.SenderName, Options.SenderEmail));
            mailMessage.To.Add(MailboxAddress.Parse(email));
            mailMessage.Subject = subject;
            mailMessage.Body = new TextPart(TextFormat.Html)
            {
                Text = htmlMessage
            };

            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect(Options.Host, Options.Port, false);
                smtpClient.Authenticate(Options.Username, Options.Password);
                await smtpClient.SendAsync(mailMessage);
                await smtpClient.DisconnectAsync(true);
            }
            
            return await Task.FromResult(true);
        }
    }
}