using Hangfire;
using System.Web;
using System.Web.Mvc;
using Versus.Models;

namespace Versus.Infrastructure
{
    public class HangFireAsyncMailService : IMailService
    {
        public void BetScoresMail(string score)
        {
            //wysyłanie maili async
            var urlHelper = new UrlHelper(HttpContext.Current.Request.RequestContext);
            string url = urlHelper.Action("BetScoresMail","Mail", new {betscore = score }, HttpContext.Current.Request.Url.Scheme);

            BackgroundJob.Enqueue(() => Helpers.CallUrl(url));
        }

        public void PasswordResetMail(string resetUrl, ForgotPasswordViewModel model)
        {
            //wysyłanie maili async
            var urlHelper = new UrlHelper(HttpContext.Current.Request.RequestContext);
            string url = urlHelper.Action("PasswordResetMail", "Mail", new { resetUrl = resetUrl, model = model.Email }, HttpContext.Current.Request.Url.Scheme);

            BackgroundJob.Enqueue(() => Helpers.CallUrl(url));
        }

        public void RegisterConfirmationMail(string confirmationUrl)
        {
            throw new System.NotImplementedException();
        }
    }
}

