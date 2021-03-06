﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AdminService.Entities;
using AdminService.Models;

namespace AdminService.Repository
{
    public interface IAdminRepository
    {
        List<Category> GetAllCategories();
        List<SubCategory> GetAllSubcategories();
        Task<bool> AddCategory(Category obj);
         Task<bool> AddSubcategory(SubCategory obj);
        Category getCategoryid(int cid);
        SubCategory getsubcategorybyid(int subid);
        void DeletCategory(int cid);
        void DeletSubCategory(int subid);
        Task<bool> updatecategory(Category obj);
        Task<bool> updatesubcategory(SubCategory obj);
     


    }
}
