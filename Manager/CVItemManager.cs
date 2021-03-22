using System;
using System.Collections.Generic;
using CVAPI.Models;

namespace CVAPI.Manager
{
    public class CVItemManager
    {
        private List<CVItem> tables;
        private List<Category> categories = new List<Category>();
        private CategoryManager cManager = new CategoryManager();

        public CVItemManager()
        {
            categories = cManager.GetAll();
            tables = new List<CVItem>()
            {
                new CVItem(1, "Under Direktør", "Valdemarsplads 1", "Something", DateTime.Today.AddMonths(-10),
                    DateTime.Today, categories[0]),
                new CVItem(2, "Under Direktør", "Valdemarsplads 1", "Something", DateTime.Today.AddMonths(-10),
                    DateTime.Today, categories[1])
            };
        }

        public List<CVItem> GetAll()
        {
            return tables;
        }

        public List<CVItem> GetByCategory(string categoryName)
        {
            List<CVItem> newList = new List<CVItem>();

            foreach (CVItem cvItem in tables)
            {
                if (cvItem.Category.Name == categoryName)
                {
                    newList.Add(cvItem);
                }
            }

            return newList;
        }
    }
}
