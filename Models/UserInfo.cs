using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVAPI.Models
{
    public class UserInfo
    {
        private int _id;
        private string _name;
        private string _phone;
        private string _email;
        private string _adresse;
        private string _description;

        public UserInfo()
        {
        }

        public UserInfo(int id, string name, string phone, string email, string adresse, string description)
        {
            _id = id;
            _name = name;
            _phone = phone;
            _email = email;
            _adresse = adresse;
            _description = description;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public string Adresse
        {
            get => _adresse;
            set => _adresse = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }
    }
}
