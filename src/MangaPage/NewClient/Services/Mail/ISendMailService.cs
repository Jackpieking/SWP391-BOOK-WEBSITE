using System.Threading.Tasks;

namespace NewClient.Services.Mail;

public interface ISendMailService
{
	Task SendMail(MailContent mailContent);

	Task SendEmailAsync(string email, string subject, string htmlMessage);
}
