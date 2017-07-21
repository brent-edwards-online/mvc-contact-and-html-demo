using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContactMVC.Services;
using NSubstitute;
using ContactMVC.Repository;
using ContactMVC.Entities;
using System.Collections.Generic;

namespace ContactMVC.Tests.Services
{
    [TestClass]
    public class TestCompetitionEntryService
    {
        IContactService _service;
        IContactRepository _repo;
        IUnitOfWork _unit;

        [TestInitialize]
        public void Initialise()
        {
            _repo = Substitute.For<IContactRepository>();
            _unit = Substitute.For<IUnitOfWork>();
            _service = new ContactService(_repo, _unit);
        }

        [TestMethod]
        [TestCategory("Test Basic Service")]
        public void TestBasicService()
        {
            //var entry = new BasicEntity();
            //var actual = _service.BasicFunction();
            Assert.IsTrue(true);
        }
        
    }
}
