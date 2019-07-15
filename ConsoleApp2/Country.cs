using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Country
    {
        static void Main(string[] args)
        {
           var kaz = new Kazakhstan();

            Console.WriteLine("1.Создать");
            Console.WriteLine("2.Редактировать");
            Console.WriteLine("3.Искать");
            Console.WriteLine("4.Удалить");
            string agropole = Console.ReadLine();
            switch (agropole)
            {
                case "1":
                    Console.WriteLine("Create");
                    Kazakhstan.Creat();
                    break;
                case "2":
                    Console.WriteLine("Redact");
                    Kazakhstan.Update();
                    break;
                case "3":
                    Console.WriteLine("Search");
                    Kazakhstan.Search();
                    break;
                case "4":
                    Console.WriteLine("Delete");
                    Kazakhstan.Delete();
                    break;
                default:
                    break;
            }
        }
    }
}
