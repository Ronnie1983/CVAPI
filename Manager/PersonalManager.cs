using CVAPI.Models;

namespace CVAPI.Manager
{
    public class PersonalManager
    {
        private UserInfo user;
        public PersonalManager()
        {
            user = new UserInfo(1, "John Doe", "+45 12 34 56 78", "my@email.com", "SomewhereStreet 5", "Info about me");
        }

        public UserInfo GetUserById(int id)
        {
            return user;
        }
    }
}
