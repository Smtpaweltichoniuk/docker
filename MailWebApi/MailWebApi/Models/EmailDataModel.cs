using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailWebApi.Models
{
    public class EmailDataModel
    {
        public string Body { get; set; }
        public string Subject { get; set; }
        public string From { get; set; }
    }
}
