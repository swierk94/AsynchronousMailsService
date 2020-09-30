using Microsoft.VisualStudio.TestTools.UnitTesting;
using Versus.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Versus.Models;
using Versus.Infrastructure;
using Moq;
using FluentAssertions;

namespace Versus.Controllers.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        public string betscore = "";
        [TestMethod]
        public void MailTest()
        {
            HomeController email = new HomeController();
           // Mock<HomeController> email = new Mock<HomeController>();
            Assert.IsNotNull(email.ScoresGenerate());


            //Mock<IMailService> mockRepo = new Mock<IMailService>();
            //MailService email = new MailService();
            //email.NumerZamowienia.Should().NotBeNullOrEmpty;

        }


        [TestMethod]
        public void param()
        {
            Mock<IMailService> mockRepo =new  Mock<IMailService>();
            var homeController = new HomeController(mockRepo.Object);
            homeController.Should();

        }
    }
}