using AdminService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminService.Repositories
{
    public interface IAdminClientRepository
    {
        List<Users> getAllUsers();
        List<Seller> getAllSellers();

    }
}
