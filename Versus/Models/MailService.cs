using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Postal;

namespace Versus.Models
{
    public class MailService : Email
    {
        
        public string To { get; set; }

        public string From { get; set; }

        public string SomeImageContentId { get; set; }

        public string Topic { get; set; }

        public string NumerZamowienia { get; set; }

        public string Header { get; set; }

        public string MailContent { get; set; }
        
        public string Greatings { get; set; }
        
        public string Signature { get; set; }



    }
}
