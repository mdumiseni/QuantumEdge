using QuantumEdge.Application.Interfaces.MessagingService;

namespace QuantumEdge.Application.Interfaces.UserService;

public class UserEmailingService(IEmailService emailService)
{
    private readonly IEmailService _emailService = emailService;
}