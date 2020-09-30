using Microsoft.VisualStudio.TestTools.UnitTesting;
using Versus.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace Versus.ViewModels.Tests
{
    [TestClass()]
    public class ScoresVMTests
    {
        [TestMethod()]
        public void ScoresVMTest()
        {
            Mock<ScoresVM> mockRepo = new Mock<ScoresVM>();


            Assert.IsTrue(mockRepo.Object.Id > 0);
        }
    }
}