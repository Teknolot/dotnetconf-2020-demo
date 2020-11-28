using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SendGrid.Helpers.Mail;
using System.Collections.Generic;

namespace SPA
{
    public static class MailSend
    {
        [FunctionName("MailSend")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            [SendGrid(ApiKey = "SendGridKey")] IAsyncCollector<SendGridMessage> messageCollector,
            ILogger log)
        {
            var postData = await req.ReadFormAsync();
            var missingFields = new List<string>();

            var fromEmail = req.Form["fromEmail"];
            var message = req.Form["message"];
            if (fromEmail == default(Microsoft.Extensions.Primitives.StringValues))
                missingFields.Add("fromEmail");
            if (message == default(Microsoft.Extensions.Primitives.StringValues))
                missingFields.Add("message");

            if (missingFields.Count > 0)
            {
                var missingFieldsSummary = String.Join(", ", missingFields);
                return new BadRequestObjectResult($"Missing field(s): {missingFieldsSummary}");
            }

            var mailMessage = new SendGridMessage();
            mailMessage.AddTo("daron@yondem.com");
            mailMessage.AddContent("text/html", message);
            mailMessage.SetFrom(new EmailAddress(fromEmail));
            mailMessage.SetSubject("SPA E-Mail");

            await messageCollector.AddAsync(mailMessage);
            return new CustomRedirectResult(req.Headers["Referer"]);
        }

        public class OutgoingEmail
        {
            public string To { get; set; }
            public string From { get; set; }
            public string Subject { get; set; }
            public string Body { get; set; }
        }
    }
}
