using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminService.Repository;
using AdminService.Entities;


namespace AdminService.Manager
{
    public class ManagerRepository:IManager
    {
        public readonly IAdminRepository _repo;

        public ManagerRepository(IAdminRepository repo)
        {
            _repo = repo;
        }

        public async Task<bool> AddCategory(Category obj)
        {
            try
            {
                bool cat = await _repo.AddCategory(obj);
                if (cat==true)
                    return true;
                else
                    return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task<bool> AddSubcategory(SubCategory obj)
        {
            try
            {
                bool subcat = await _repo.AddSubcategory(obj);
                if(subcat==true)
                {
                    return true;
                }
                else
                {
                   return  false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

            public string DeletCategory(int cid)
             {
            _repo.DeletCategory(cid);
            return "Category deleted";
            }

        public string DeletSubCategory(int subid)
        {
            _repo.DeletSubCategory(subid);
            return "subcategory deleted";
        }

        public  List<Category> GetAllCategories()
        {
            try
            {
                List<Category> cat = _repo.GetAllCategories().ToList();
                return cat;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<SubCategory> GetAllSubcategories()
        {
            try
            {
                List<SubCategory> subcat = _repo.GetAllSubcategories().ToList();
                if (subcat.Count != 0)
                    return subcat;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Category getCategoryid(int cid)
        {
            try
            {
                Category cat= _repo.getCategoryid(cid);
                if (cat!= null)
                {
                    return cat;
                }
                else
                    return null;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public SubCategory getsubcategorybyid(int subid)
        {
            try
            {
                SubCategory subcat = _repo.getsubcategorybyid(subid);
                if (subcat != null)
                {
                    return subcat;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public  async Task<bool> updatecategory(Category obj)
        {
            try
            {
                bool cat = await _repo.updatecategory(obj);
                if (cat==true)
                {
                    return true;
                }
                else
                    return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public  async Task<bool> updatesubcategory(SubCategory obj)
        {
            try
            {
                bool subcat = await _repo.updatesubcategory(obj);
                if (subcat == true)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
