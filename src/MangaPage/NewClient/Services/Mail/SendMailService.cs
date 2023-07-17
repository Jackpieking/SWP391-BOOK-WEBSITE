using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;
using NewClient.Options;
using System;
using System.Threading.Tasks;

namespace NewClient.Services.Mail;

public class SendMailService : ISendMailService
{
	private readonly MailSettings mailSettings;
	private readonly ILogger<SendMailService> logger;

	public SendMailService(IOptions<MailSettings> _mailSettings, ILogger<SendMailService> _logger)
	{
		mailSettings = _mailSettings.Value;
		logger = _logger;

		logger.LogInformation("Create SendMailService");
	}

	public async Task SendMail(MailContent mailContent)
	{
		MimeMessage email = new()
		{
			Sender = new MailboxAddress(mailSettings.DisplayName, mailSettings.Mail)
		};

		email.From.Add(new MailboxAddress(mailSettings.DisplayName, mailSettings.Mail));

		email.To.Add(MailboxAddress.Parse(mailContent.To));

		email.Subject = mailContent.Subject;


		BodyBuilder builder = new()
		{
			HtmlBody = mailContent.Body
		};

		email.Body = builder.ToMessageBody();

		// dùng SmtpClient của MailKit
		using SmtpClient smtp = new();

		try
		{
			await smtp.ConnectAsync(
				mailSettings.Host,
				mailSettings.Port,
				SecureSocketOptions.StartTls);

			await smtp.AuthenticateAsync(
				mailSettings.Mail,
				mailSettings.Password);

			await smtp.SendAsync(email);

			await smtp.DisconnectAsync(true);
		}
		catch (Exception ex)
		{
			logger.LogError(ex.Message);
		}

		smtp.Disconnect(true);

		logger.LogInformation("send mail to " + mailContent.To);

	}
	public async Task SendEmailAsync(string email, string subject, string htmlMessage)
	{
		await SendMail(new MailContent()
		{
			To = email,
			Subject = subject,
			Body = htmlMessage
		});
	}
}
