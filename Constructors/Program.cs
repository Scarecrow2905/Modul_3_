using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "The Witcher: The Last Wish";
            book1.author = "Andrzej Sapowski";
            book1.pages = 200;

            Book book2 = new Book();
            book2.title = "Harry Potter";
            book2.author = "Andrzej Sapowski";
            book2.pages = 200;

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);

            Console.ReadLine();
        }
    }
}
