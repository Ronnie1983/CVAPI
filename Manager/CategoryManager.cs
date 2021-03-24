using System.Collections.Generic;
using CVAPI.Models;

namespace CVAPI.Manager
{
    public class CategoryManager
    {
        private static readonly  List<Category> Categories = new List<Category>()
        {
            new Category(1, "WorkItem"),
            new Category(2, "Education")
        };

        public List<Category> GetAll()
        {
            return Categories;
        }
    }
}
