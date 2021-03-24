using System;
using System.Collections.Generic;
using CVAPI.Models;

namespace CVAPI.Manager
{
    public class CVItemManager
    {
        private readonly List<CVItem> _cvItems;
        private readonly CategoryManager _cManager = new CategoryManager();
       

        public CVItemManager()
        {
            var categories = _cManager.GetAll();
            _cvItems = new List<CVItem>()
            {
                new CVItem(1, "Under Direktør", "Valdemarsplads 1", "Something", DateTime.Today.AddMonths(-10),
                    DateTime.Today, categories[0]),
                new CVItem(2, "Under Direktør", "Valdemarsplads 1", "Something", DateTime.Today.AddMonths(-10),
                    DateTime.Today, categories[1])
            };
        }

        public List<CVItem> GetAll()
        {
            return _cvItems;
        }

        public List<CVItem> GetByCategory(string categoryName)
        {
            List<CVItem> newList = new List<CVItem>();

            foreach (CVItem cvItem in _cvItems)
            {
                if (cvItem.Category.Name == categoryName)
                {
                    newList.Add(cvItem);
                }
            }

            return newList;
        }

        public bool Post(CVItem item)
        {
            int beforeAdd = _cvItems.Count;
            _cvItems.Add(item);
            bool success = beforeAdd + 1 == _cvItems.Count;
            return success;
        }

        public bool Delete(int id)
        {
            var itemToRemove = _cvItems.Find(x => x.Id == id);
            return _cvItems.Remove(itemToRemove);
        }
    }
}
