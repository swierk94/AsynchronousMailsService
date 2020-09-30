using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Versus.Models;

namespace Versus.Infrastructure
{
    public interface IMailService
    {
        void PasswordResetMail(string resetUrl, string modelMail);
        void RegisterConfirmationMail(string confirmationUrl);
        void BetScoresMail(string score);
    }
}
