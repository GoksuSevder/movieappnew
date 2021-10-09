using System.Collections.Generic;
using System.Linq;
using movieappnew.Models;

namespace movieappnew.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories =null;

        static CategoryRepository() 
        {
         _categories= new List<Category>(){
           new Category(){
               Id=1,
               Name="Macera"
           },
           new Category(){
               Id=2,
               Name="Aksiyon"
           },
            new Category(){
               Id=3,
               Name="Romantik"
           },
            new Category(){
               Id=4,
               Name="Bilim Kurgu"
           },
            new Category(){
               Id=5,
               Name="Fantastik"
           }
         };
                    
            

        }
       public static List<Category> Categories
        {
           get
           {
               return _categories;
            }
        }

        public static void AddCategory(Category entity)
       {
             _categories.Add(entity);
       }
        public static Category GetById(int id)
        {
            return _categories.FirstOrDefault(i => i.Id == id);
        }
    }
}