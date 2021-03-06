﻿using AdminService.Entities;
using AdminService.Manager;
using AdminService.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingAdminClientService
{
    [TestFixture]
    class TestingAdminClients_repository
    {
        AdminClientRepositorycs _repo;
        [SetUp]
        public void setup()
        {
            _repo = new AdminClientRepositorycs(new EmartDBContext());

        }
        [TearDown]
        public void Teardown()
        {
            _repo = null;
        }

        [Test]
        [Description("Get All Sellers")]
        public void TestGetAllSellers()
        {
            try
            {
                var result = _repo.getAllSellers();
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
                var result = _repo.getAllUsers();
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
