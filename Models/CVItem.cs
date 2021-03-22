using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVAPI.Models
{
    public class CVItem
    {
        private int _id;
        private string _title;
        private string _location;
        private string _description;
        private DateTime _dateFrom;
        private DateTime _dateTo;
        private Category _category;


        public CVItem()
        {
        }

        public CVItem(int id, string title, string description)
        {
            _id = id;
            _title = title;
            _description = description;
        }

        public CVItem(int id, string title, string location, string description, DateTime dateFrom, DateTime dateTo, Category category)
        {
            _id = id;
            _title = title;
            _location = location;
            _description = description;
            _dateFrom = dateFrom;
            _dateTo = dateTo;
            _category = category;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string Location
        {
            get => _location;
            set => _location = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public DateTime DateFrom
        {
            get => _dateFrom;
            set => _dateFrom = value;
        }

        public DateTime DateTo
        {
            get => _dateTo;
            set => _dateTo = value;
        }

        public Category Category
        {
            get => _category;
            set => _category = value;
        }
    }
}
