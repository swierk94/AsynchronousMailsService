using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Versus.Models;

namespace Versus.Controllers
{
    public class MailController : Controller
    {
        // GET: Mail
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult BetScoresMail(string betscore)
        {

            MailService email = new MailService();
            email.From = "swierq94@gmail.com";
            email.To = "swierq94@gmail.com";
            //Dołączenie obrazka do treści maila
            Attachment someImageAttachment = new Attachment("C:\\Users\\Dolar\\source\\repos\\VersusRepo\\Versus\\Img\\a.jpg");
            email.SomeImageContentId = someImageAttachment.ContentId;
            email.Header = "obstawiłeś: ";
            email.MailContent = "";
            email.Topic = "";
            email.Signature = "Versus";
            email.NumerZamowienia = betscore;
            email.Attach(someImageAttachment);
            email.Send();


            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        public ActionResult PasswordResetMail(string resetUrl, string modelMail)
        {
            MailService email = new MailService();
            email.From = "swierq94@gmail.com";
            email.To = modelMail;
            //Dołączenie obrazka do treści maila
            Attachment someImageAttachment = new Attachment("C:\\Users\\Dolar\\source\\repos\\VersusRepo\\Versus\\Img\\reset.jpg");
            email.SomeImageContentId = someImageAttachment.ContentId;
            email.NumerZamowienia = resetUrl;
            email.Header = "zresetowałeś swoje hasło.";
            email.MailContent = "Kliknij w poniższy link aby zresetować hasło do konta. Jeśli mail dotarł do Ciebie przypadkowo, zignoruj go";
            email.Topic = "Resetowanie hasła - kliknij w link w wiadomości";
            email.Signature = "Versus";

            email.Attach(someImageAttachment);
            email.Send();


            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

    }
}