using Microsoft.Extensions.Configuration;
using QuantumEdge.Application.Interfaces.MessagingService;

namespace QuantumEdge.Application.Interfaces.UserService;

public class UserEmailingService(IEmailService emailService, IConfiguration configuration)
{
    public async Task<bool> SendNewUserWelcomeEmail()
    {
        var subject = "Account Activation";

        var content = "";
        
        var sendMail = await emailService.SendEmailAsync(configuration[""], "", subject, content);
        return sendMail;
    }
}