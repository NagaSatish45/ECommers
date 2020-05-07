using AdminService.Entities;
using AdminService.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using AdminService.Extensions;
using AdminService.Models;

namespace AdminService.Manager
{
    public class AdminClientMager : IAdminClientManager
    {
        private readonly IAdminClientRepository _repo;
        public AdminClientMager(IAdminClientRepository repo)
        {
            _repo = repo;
        }
        public List<Seller> getAllSellers()
        {
            try
            {
                List<Seller> seller = _repo.getAllSellers().ToList();
                return seller;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public List<Users> getAllUsers()
        {
            try
            {
                List<Users> user = _repo.getAllUsers().ToList();
                return user;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
