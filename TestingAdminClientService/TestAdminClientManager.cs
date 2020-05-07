using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using AdminService.Manager;
using AdminService.Repositories;
using AdminService.Entities;

namespace TestingAdminClientService
{
    [TestFixture]
    class TestAdminClientManager
    {
        AdminClientMager _manager;

        
        [SetUp]
        public void setup()
        {
            _manager = new AdminClientMager(new AdminClientRepositorycs(new EmartDBContext()));

        }
        [TearDown]
        public void Teardown()
        {
            _manager = null;
        }
        [Test]
        [Description("Get All Sellers")]
        public void TestGetAllSellers()
        {
            try
            {
                var result = _manager.getAllSellers();
                Assert.NotNull(result);
                Assert.Greater(result.Count, 0);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.InnerException.Message);
            }
        }
        [Test]
        [Description("Get All Users")]
        public void TestGetAllUsers()
        {
            try
            {
                var result = _manager.getAllUsers();
                Assert.NotNull(result);
                Assert.Greater(result.Count, 0);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.InnerException.Message);
            }
        }


    }
}
