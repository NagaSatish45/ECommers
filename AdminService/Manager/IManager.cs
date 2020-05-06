using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminService.Entities;
using AdminService.Models;


namespace AdminService.Manager
{
     public interface IManager
    {
        List<Category> GetAllCategories();
        List<SubCategory> GetAllSubcategories();
        Task<bool> AddCategory(category obj);
        Task<bool> AddSubcategory(subcategory obj);
        Category getCategoryid(int cid);
        SubCategory getsubcategorybyid(int subid);
        string DeletCategory(int cid);
        string DeletSubCategory(int subid);
        Task<bool> updatecategory(Category obj);
        Task<bool> updatesubcategory(SubCategory obj);
        List<Users> getAllBuyers();
    }
}
