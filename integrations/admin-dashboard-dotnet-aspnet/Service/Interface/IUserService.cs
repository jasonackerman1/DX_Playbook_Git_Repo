using System.Collections.Generic;
using App.Models;

namespace App.Service 
{
    public interface IUserService
    {
        void SaveChanges();

        IEnumerable <User> GetUsers();

        User GetUserById(int id);

        User GetUserByEmail(string email);

        User AddUser(User user);

        void UpdateUser(User user);

        void DeleteUser(User user);
    }
}