using SkillBox_Csharp_DZ11.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillBox_Csharp_DZ11.Models
{
    internal class UsersDb : IManageClients
    {
        private List<AbstractClient> _users;

        public List<AbstractClient> Users => _users;

        public UsersDb()
        {
            _users = new List<AbstractClient>();
        }

        public void CreateUser(AbstractClient user)
        {
            _users.Add(user);
            Console.WriteLine($"User {user.FirstName} {user.LastName} created.");
        }

        public void UpdateUser(int id, AbstractClient updatedUser)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                user.FirstName = updatedUser.FirstName;
                user.LastName = updatedUser.LastName;
                user.PhoneNumber = updatedUser.PhoneNumber;
                user.PassportNumber = updatedUser.PassportNumber;
                Console.WriteLine($"User {user.FirstName} {user.LastName} updated.");
            }
            else
            {
                Console.WriteLine($"User with ID {id} not found.");
            }
        }

        public void DeleteUser(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _users.Remove(user);
                Console.WriteLine($"User {user.FirstName} {user.LastName} deleted.");
            }
            else
            {
                Console.WriteLine($"User with ID {id} not found.");
            }
        }

        public void Show(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                Console.WriteLine($"ID: {user.Id}, Name: {user.FirstName} {user.LastName}, Phone: {user.PhoneNumber}, Passport: {user.PassportNumber}");
            }
            else
            {
                Console.WriteLine($"User with ID {id} not found.");
            }
        }

        public void ShowAll()
        {
            foreach (var user in _users)
            {
                Console.WriteLine($"ID: {user.Id}, Name: {user.FirstName} {user.LastName}, Phone: {user.PhoneNumber}, Passport: {user.PassportNumber}");
            }
        }
    }
}
