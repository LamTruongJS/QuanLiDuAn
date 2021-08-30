using CoreLibrary.Areas.Reader.Models;
using CoreLibrary.Helper.Model;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary.Helper.Services
{
    public class EmailService
    {
        private const string templatePath = @"Helper/Template/{0}.html";
        private readonly SMTPConfigModel _smtpConfig = null;
        public EmailService(IOptions<SMTPConfigModel> options)
        {
            _smtpConfig = options.Value;
        }
        public async Task SendAsync(EmailModel emailModel)
        {
            MailMessage mail = new MailMessage()
            {
                SubjectEncoding = Encoding.UTF8,
                Subject = emailModel.Subject,
                IsBodyHtml = _smtpConfig.IsBodyHtml,
                From = new MailAddress(_smtpConfig.SenderAddress, _smtpConfig.SenderDisplayName),
                Body = GetEmailBody(emailModel.Body, emailModel.PlaceHolders)
            };

            foreach(var i in emailModel.ToEmails)
            {
                mail.To.Add(i);
            }

            NetworkCredential credential = new NetworkCredential()
            {
                UserName = _smtpConfig.UserName,
                Password = _smtpConfig.Password
            };

            SmtpClient smtpClient = new SmtpClient()
            {
                UseDefaultCredentials = _smtpConfig.UseDefaultCredentials,
                Credentials = credential,
                EnableSsl = _smtpConfig.EnableSSL,
                Host = _smtpConfig.Host,
                Port = _smtpConfig.Port
            };

            await smtpClient.SendMailAsync(mail);

        }
        private string GetEmailBody(string template, List<KeyValuePair<string, string>> placeHolders)
        {
            var body = File.ReadAllText(string.Format(templatePath, template));
            if (!string.IsNullOrEmpty(body) && placeHolders != null)
                foreach (var i in placeHolders)
                    if (body.Contains(i.Key))
                        body = body.Replace(i.Key, i.Value);
            return body;
        }
    }
}
