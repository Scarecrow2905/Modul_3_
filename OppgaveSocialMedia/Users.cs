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
        public List<Users> Friends { get; } = new List<Users>();

        // Constructor
        public Users (string name, string email, int age)
        {
            UserName = name;
            Email = email;
            Age = age;
        }

        // Methods
        public void ShowProfile()
        {
            Console.WriteLine($"Hei, { UserName }!");
            Console.WriteLine($"Email: { Email }");
            Console.WriteLine($"Age: { Age }");
        }

        public void FriendList() // Work in progress
        {
            Console.WriteLine("Your friends: ");
            foreach (Users Friend in Friends)
            {
                Console.WriteLine(Friend.UserName);
            }
        }
        public void ViewFriend(Users Friend)
        {
            Console.WriteLine($"din venn{Friend.UserName}");
            Console.WriteLine($"Age: {Friend.Age}");
            Console.WriteLine($"email: {Friend.Email}");
        }

        public void AddFriend(Users Friend)
        {
            Friends.Add(Friend);
            Console.WriteLine($" La til {Friend.UserName}");
        }

        public void RemoveFriend(Users Friend)
        {
            for (int i = 0; i < Friends.Count; i++)
                {
                  if (Friend.UserName == Friends[i].UserName)
                  {
                        Friends.RemoveAt(i);
                        Console.WriteLine($"{Friend.UserName} Ble fjernet som venn.");
                  }
            }
        }
        
     }

}

