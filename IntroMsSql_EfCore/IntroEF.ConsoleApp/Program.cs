using IntroEF.ConsoleApp.Models;
using System;
using System.Linq;

namespace IntroEF.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new KontaktHomeDbContext();

            var persons = db.Persons.ToList();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("==========================================");
            foreach (var p in persons)
            {
                Console.WriteLine($"Id: {p.Id}, name: {p.Name}, surname: {p.Surname}");
                if (p != persons.Last())
                {
                    Console.WriteLine("------------------------------------------");
                }
            }
            Console.WriteLine("==========================================");
        }
    }
}
