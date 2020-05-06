using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminService.Extensions;
using AdminService.Entities;
using AdminService.Models;

namespace AdminService.Repository
{
    public class AdminRepositoty : IAdminRepository
    {
        private readonly EmartDBContext _context;
        public AdminRepositoty(EmartDBContext context)
        {
            _context = context;
        }
        public async Task<bool> AddCategory(category obj)
        {
            try
            {
                _context.Add(obj);
                await _context.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }



        }

        public async Task<bool> AddSubcategory(subcategory obj)
        {
            try
            {
                _context.Add(obj);
                var cat = await _context.SaveChangesAsync();
                if (cat > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeletCategory(int cid)
        {
            Entities.Category c = _context.Category.SingleOrDefault(e => e.Cid == cid);
            _context.Remove(c);
            _context.SaveChanges();
        }


        public void DeletSubCategory(int subid)
        {
            Entities.SubCategory c = _context.SubCategory.SingleOrDefault(e => e.Subid == subid);

            _context.Remove(c);
            _context.SaveChanges();

        }

        public List<Users> getAllBuyers()
        {
            List<Users> users = _context.Users.ToList();
            return users;
        }

        public List<Entities.Category> GetAllCategories()
        {
            List<Entities.Category> c = _context.Category.ToList();
            return c;
           
        }

        public List<Entities.SubCategory> GetAllSubcategories()
        {

            List<Entities.SubCategory> c = _context.SubCategory.ToList();
                return c;
            
           
           
        }

        public Entities.Category getCategoryid(int cid)
        {
            return _context.Category.SingleOrDefault(e=>e.Cid==cid);
           

        }

        public Entities.SubCategory getsubcategorybyid(int subid)
        {
            return _context.SubCategory.Find(subid);

        }

        public async Task<bool> updatecategory(Entities.Category obj)
        {
            try
            {
                _context.Category.Update(obj);
               await _context.SaveChangesAsync();
                    return true;
            
            }
            catch (MyAppException ex)
            {
               
                throw ex;
            }
        }

        public async Task<bool> updatesubcategory(Entities.SubCategory obj)
        {

            try
            {
                _context.SubCategory.Update(obj);
                 await _context.SaveChangesAsync();
                
                    return true;
               
            }
            catch (MyAppException ex)
            {
                
                throw ex;
            }

        }
    }
}
