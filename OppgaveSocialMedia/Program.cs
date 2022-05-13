using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppgaveSocialMedia;

internal class Program
{
    static void Main(string[] args)
    {
        bool loggedIn = false;


        Users Tomas = new Users("Tomas Nøklegaard", "tomas@getAcademy.no", 26);
        Users Tommy = new Users("Tommy Håvåg", "tommy@getAcademy.no", 28);
        Users Berit = new Users("Berit Olga", "berit@getAcademy.no", 40);
        Users Inga = new Users("Inga Toppen", "inga@getAcademy.no", 66);
        Users Bjarte = new Users("Bjarte Ulf", "bjarte@getAcademy.no", 38);

        Users[] AllUsers = new Users[] {Tomas, Tommy, Berit, Inga, Bjarte};

        Users LoggedInnUser = Tomas;

        LoggedInnUser.ShowProfile();
        

        while (true)
        {
            string kommando = Console.ReadLine().ToLower();
           // string[] splitKommando = kommando.Split(' ');
            Console.Clear();
            LoggedInnUser.ShowProfile();
            

            switch (kommando)
            {
                case "add":
                    
                    var addFriend = Console.ReadLine();
                    var didAdd = false;
                    foreach (var person in AllUsers)
                    {
                        if (addFriend == person.UserName)
                        {
                            LoggedInnUser.AddFriend(person);
                            didAdd= true;  
                        }
                       
                    }
                    if(didAdd== false) Console.WriteLine("Brukeren finnes ikke");

                    break;

                case "remove": 
                    var removeFriend = Console.ReadLine();
                    break;

                case "friends":
                    LoggedInnUser.FriendList();
                    break;

                case "view":
                    printUsers(AllUsers);
                   // LoggedInnUser.ViewFriend(GetUserFromName(AllUsers));
                    break;
                default:
                    Console.WriteLine("Command is not available.");
                    break;
            }
        }

        static Users GetUserFromName(string name, Users[] users)
        {
            foreach(Users user in users)
            {
                if (user.UserName.ToLower().Contains(name))
                {
                    return user;
                }
            }
            return null;
        }

        static void printUsers(Users[] users)
        {
            foreach (Users user in users)
            {
                Console.WriteLine(user.UserName);
            }
        }

    }

}
                


    
