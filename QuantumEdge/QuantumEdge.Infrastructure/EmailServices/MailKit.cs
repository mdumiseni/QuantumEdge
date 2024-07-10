using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MimeKit;
using MimeKit.Text;
using QuantumEdge.Application.Interfaces.MessagingService;

namespace QuantumEdge.Infrastructure.EmailServices;

public class MailKit : IEmailService
{
    private readonly ILogger<MailKit> _logger;
    private readonly IConfiguration _configuration;

    public MailKit(ILogger<MailKit> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }
    
    
    public async Task<bool> SendEmailAsync(string from, string to, string subject, string content)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress("", from));
        message.To.Add(new MailboxAddress("", to));
        message.Subject = subject;
        message.Body = new TextPart(TextFormat.Html) { Text = content };

        using var client = new SmtpClient();

        await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
        await client.AuthenticateAsync("mdumiseni.nyandu@gmail.com", "");
        await client.SendAsync(message);
        await client.DisconnectAsync(true);

        _logger.LogInformation("Sending email using mailkit");
        return true;
    }

    public async Task<bool> SendWithAttachmentEmailAsync(string from, string to, string subject, string content, List<string> attachments)
    {
        throw new NotImplementedException();
    }
}
