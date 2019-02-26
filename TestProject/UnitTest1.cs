using AspnetCoreEFCoreExample.Models;
using AspnetCoreEFCoreExample.Repositories;
using AspnetCoreEFCoreExample.Service;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class MYFirstServiceTest
    {
        private Mock<IExampleRepository> _repo;
        private MyFirstService _service;
        [SetUp]
        public void Setup()
        {
            _repo = new Mock<IExampleRepository>();
            _repo.Setup(m => m.GetAll())
                .Returns(new List<MyModel> { new MyModel()}.AsQueryable());
            _service = new MyFirstService(_repo.Object);
        }

        [Test]
        public void Test1()
        {
            //assemble

            //act
            var models = _service.GetModels();
            //assert
            Assert.IsTrue(models.Count() == 1);
        }
    }
}