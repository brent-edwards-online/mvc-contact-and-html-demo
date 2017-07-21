using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Web.Mvc;
using BasicMVC.Controllers;
using BasicMVC.Entities;
using BasicMVC.Services;

namespace BasicMVC.Tests.Controllers
{
    [TestClass]
    public class BasicControllerTest
    {
        private BasicController _controller;
        private IBasicService _basicService;
        private IEmailService _emailService;
        private IMessageFormatter _messageFormatter;

        [TestInitialize]
        public void Initialize()
        {
            _basicService = Substitute.For<IBasicService>();
            _emailService = Substitute.For<IEmailService>();
            _messageFormatter = Substitute.For<IMessageFormatter>();
            _controller = new BasicController(_basicService, _emailService, _messageFormatter);
        }

        [TestMethod]
        [TestCategory("Test Basic Controller")]
        public void CanCreateABasicController()
        {
            var actual = _controller.BasicAction() as JsonResult;
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("Test Basic Controller")]
        public void AnotherTest()
        {
            Assert.IsTrue(true);
        }
    }
}
