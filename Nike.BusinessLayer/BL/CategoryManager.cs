using Nike.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike.BusinessLayer.BL
{
   public class CategoryManager
    {
       public static void AddCategory(Category category)
       {
           using (NikeContext db = new NikeContext())
           {
               db.Categories.Add(category);
               db.SaveChanges();
           }
       }

       public static Category GetCategoryById(int id)
       {
           using (NikeContext db = new NikeContext())
           {
               Category category = db.Categories.FirstOrDefault(x => x.ID == id);
               return category;
           }
       }

       public static List<Category> GetAllCategories()
       {
           using (NikeContext db = new NikeContext())
           {
               List<Category> categorylist = db.Categories.OrderBy(x => x.Name).ToList();
               return categorylist;
           }
       }
    }
}
