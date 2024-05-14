using Microsoft.Extensions.Logging;
using QuantumEdge.Application.Interfaces.MessagingService;
using SendGrid;

namespace QuantumEdge.Infrastructure.EmailServices;

public class SendGrid : IEmailService
{
    private readonly ILogger<SendGrid> _logger;
    private readonly ISendGridClient _sendGridClient;

    public SendGrid(ILogger<SendGrid> logger, ISendGridClient sendGridClient)
    {
        _logger = logger;
        _sendGridClient = sendGridClient;   
    }
    
    public async Task<bool> SendEmailAsync(string from, string to, string subject, string content)
    {
        _logger.LogInformation("Sending email using sendgrid");
        return true;
    }

    public async Task<bool> SendWithAttachmentEmailAsync(string from, string to, string subject, string content, List<string> attachments)
    {
        _logger.LogInformation("Sending email with attachment(s) using mailkit");
        return true;
    }
}