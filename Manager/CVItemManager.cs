using System;
using System.Collections.Generic;
using System.Linq;
using CVAPI.Models;

namespace CVAPI.Manager
{
    public class CVItemManager
    {
        private static readonly CategoryManager CatManager = new CategoryManager();

        private static readonly List<CVItem> CvItems = new List<CVItem>
        {
             new CVItem(1, "Underdirektør", "Valdemarsplads 1", "Something", DateTime.Today.AddMonths(-10), DateTime.Today, CatManager.GetAll()[0]),
             new CVItem(2, "Datamatiker", "Erhvervsakademi Sjælland, Roskilde", "En beskrivelse af hvad man har lært under uddannelsesforløbet", DateTime.Today.AddMonths(-10), DateTime.Today, CatManager.GetAll()[1])
        };

        public List<CVItem> GetAll()
        {
            return CvItems;
        }

        public List<CVItem> GetByCategory(string categoryName)
        {
            List<CVItem> newList = new List<CVItem>();

            foreach (CVItem cvItem in CvItems)
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
            item.Id = AutoGenerateId();
            int beforeAdd = CvItems.Count;
            CvItems.Add(item);
            bool success = beforeAdd + 1 == CvItems.Count;
            return success;
        }

        public bool Delete(int id)
        {
            var itemToRemove = CvItems.Find(x => x.Id == id);
            return CvItems.Remove(itemToRemove);
        }

        private int AutoGenerateId()
        {
            return CvItems.Count > 0 ? CvItems.Max(x => x.Id) + 1 : 1;
        }
    }
}
