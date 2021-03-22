using System.Collections.Generic;
using CVAPI.Models;

namespace CVAPI.Manager
{
    public class CategoryManager
    {
        private List<Category> categories;

        public CategoryManager()
        {
            categories = new List<Category>()
            {
                new Category(1, "Work Experiance"),
                new Category(2, "Education")
            };
        }


        public List<Category> GetAll()
        {
            return categories;
        }
    }
}
