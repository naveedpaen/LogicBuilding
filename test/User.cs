using System;
using System.Collections.Generic;
using System.Text;

namespace test
{

    public interface IUserHandler { }

    public class UserHandler
    {
        public void SaveUser(User u)
        {
            int userId = 1; 
            //  Save User
        }

        public List<User> GetAllUsers()
        {
            // Get all users
            return null;
        }

        public void SendEmail ()
        {
            // Send Email
        }
    }


    public class User
    {
        public int Id { get; set; }
    }
}
