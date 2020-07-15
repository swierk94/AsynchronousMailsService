//using Microsoft.AspNet.Identity;
//using System;
//using System.Net;
//using System.Net.Mail;
//using System.Web.Mvc;
//using Versus.Infrastructure;
//using Versus.Models;

//namespace Versus.Infrastructure
//{
//    public class PostalMailService : IMailService
//    {
//        public void BetScoresMail(string betscore)
//        {
//            MailService email = new MailService();
//            email.From = "swierq94@gmail.com";
//            email.To = "swierk94@wp.pl";


//            //Dołączenie obrazka do treści maila
//            Attachment someImageAttachment = new Attachment("C:\\Users\\Dolar\\source\\repos\\VersusRepo\\Versus\\Img\\a.jpg");
//            email.SomeImageContentId = someImageAttachment.ContentId;
//            //email.NumerZamowienia = (string)Session["score"];
//            email.NumerZamowienia = betscore;
//            email.Attach(someImageAttachment);
//            email.Send();

//           // return new HttpStatusCodeResult(HttpStatusCode.OK);
//        }

//        public void PasswordResetMail(string resetUrl)
//        {
//            MailService email = new MailService();
//            email.From = "swierq94@gmail.com";
//            email.To = "swierk94@wp.pl";


//            //Dołączenie obrazka do treści maila
//            Attachment someImageAttachment = new Attachment("C:\\Users\\Dolar\\source\\repos\\VersusRepo\\Versus\\Img\\reset.jpg");
//            email.SomeImageContentId = someImageAttachment.ContentId;
//            //email.NumerZamowienia = (string)Session["score"];
//            email.NumerZamowienia = resetUrl;
//            email.Attach(someImageAttachment);
//            email.Send();
//        }

//        public void RegisterConfirmationMail(string confirmationUrl)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}