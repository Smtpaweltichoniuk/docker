using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using MailWebApi.Models;

namespace MailWebApi.Logic
{
    public class EmailApi
    {
        public static void SendEmail(EmailDataModel data)
        {
            //var address = Environment.GetEnvironmentVariable("TrainingSmtp");

            //using (var client = new SmtpClient(address))
            //{
            //    client.Port = 25;
            //    client.DeliveryMethod = SmtpDeliveryMethod.Network;

            //    var mailMessage = new MailMessage
            //    {
            //        From = new MailAddress(data.From),
            //        Body = emailMessage.Body,
            //        Subject = emailMessage.Subject
            //    };

            //    mailMessage.To.Add(emailMessage.To);
            //    client.Send(mailMessage);
            //}
        }
    }
}
