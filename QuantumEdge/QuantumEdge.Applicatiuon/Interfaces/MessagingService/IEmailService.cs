namespace QuantumEdge.Application.Interfaces.MessagingService;

public interface IEmailService
{
    Task<bool> SendEmailAsync(string from, string to, string subject, string content);
    Task<bool> SendWithAttachmentEmailAsync(string from, string to, string subject, string content, List<string> attachments);
    
}