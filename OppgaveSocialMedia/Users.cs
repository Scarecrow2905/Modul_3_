using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppgaveSocialMedia
{
     internal class Users
    {
        // Properties
        public string UserName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public List<Users> friends { get; } = new List<Users>();

        // Constructor
        public Users (string name, string email, int age)
        {
            this.Name = name;
            this.Email = email;
            this.Age = age;
        }

        // Methods
        public void ShowProfile()
        {
            Console.WriteLine($"Hei, { Name }!");
            Console.WriteLine($"Email: { Email }");
            Console.WriteLine($"Age: { Age }");
        }

        public void FriendList() // Work in progress
        {
            Console.WriteLine("Your friends: ");
            foreach (Users friend in friends)
            {
                Console.WriteLine(friend.Name);
            }

        }
    }

}

