using Microsoft.VisualStudio.TestTools.UnitTesting;
using Versus.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versus.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
       


        [TestMethod()]
        public void param()
        {
            HomeController jest = new HomeController();

            string aaa = jest.ab;

            Assert.IsNotNull(aaa);
        }
    }
}