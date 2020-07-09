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
            email.To = "swierk94@wp.pl";
            //Dołączenie obrazka do treści maila
            Attachment someImageAttachment = new Attachment("C:\\Users\\Dolar\\source\\repos\\VersusRepo\\Versus\\Img\\a.jpg");
            email.SomeImageContentId = someImageAttachment.ContentId;
            //email.NumerZamowienia = (string)Session["score"];
            email.NumerZamowienia = betscore;
            email.Attach(someImageAttachment);
            email.Send();


            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

    }
}