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
            string[] splitKommando = kommando.Split(' ');
            Console.Clear();
            LoggedInnUser.ShowProfile();
        }
    }

}

    
