using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppgaveSocialMedia;

public class Program
{
    static void Main(string[] args)
    {
        bool loggedIn = false;
        //if(userName = false && password = false)
        //{
        //    Console.WriteLine("invalid passward or username");
        //}else()
        

        Users user1 = new Users();
        user1.userName = "Tommy";
        user1.password = "1234";
        user1.friends = 5;

        Users user2 = new Users();
        user2.userName = "Tomas";
        user2.password = "asdf";
        user2.friends = 0;
        //Console.WriteLine(user2.userName);
        //Console.WriteLine(user2.password);

        Console.WriteLine("Brukernavn: ");
        string userName = Console.ReadLine();
        Console.WriteLine("Passord: ");
        string password = Console.ReadLine();
        Console.WriteLine($"Antall venner: {user1.friends}");

        if (userName == "Tommy" && password =="1234")
        {
            loggedIn = true;
            Console.WriteLine("du er logget inn");
            FriendList();
        }
        else
        {
            loggedIn = false;
            Console.WriteLine("Ugyldig passord/brukernavn.");
        }

    }

    static void FriendList()
    {
        Console.WriteLine("Antall venner: ");
        //user1.friends = 1;

        otherUsers otherUser1 = new otherUsers();
        otherUser1.name = "Berit";

        Console.WriteLine("Dine venner: ");
        Console.WriteLine("Navn: " + otherUser1.name);    

    }
}

