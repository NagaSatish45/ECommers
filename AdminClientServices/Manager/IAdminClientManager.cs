using AdminService.Entities;
using AdminService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminService.Manager
{
    public interface IAdminClientManager
    {
        List<Users> getAllUsers();
        List<Seller> getAllSellers();
    }
}
