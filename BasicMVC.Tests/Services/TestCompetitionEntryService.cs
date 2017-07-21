using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMVC.Services;
using NSubstitute;
using BasicMVC.Repository;
using BasicMVC.Entities;
using System.Collections.Generic;

namespace BasicMVC.Tests.Services
{
    [TestClass]
    public class TestCompetitionEntryService
    {
        IBasicService _service;
        IBasicRepository _repo;
        IUnitOfWork _unit;

        [TestInitialize]
        public void Initialise()
        {
            _repo = Substitute.For<IBasicRepository>();
            _unit = Substitute.For<IUnitOfWork>();
            _service = new BasicService(_repo, _unit);
        }

        [TestMethod]
        [TestCategory("Test Basic Service")]
        public void TestBasicService()
        {
            var entry = new BasicEntity();
            var actual = _service.BasicFunction();
            Assert.AreEqual(true, actual);
        }
        
    }
}
