using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Kazakhstan
    {
        /*
        private string vegetables;
        private string pole;
        private string country;
        private string poliv;
        private string culture;
        //public bool Creat { get; set; }
        // public bool Redact { get; set; }
        ///public bool Search { get; set; }
        // public bool Delete { get; set; }
    
            /*
        public bool  vegetables { get; set; }
        public bool  pole { get; set; }
        public bool  country { get; set; }
        public bool  poliv { get; set; }
        public bool  culture { get; set; }*/
        
        public static void Creat()
        {
            Console.WriteLine("Выберите поле");
            string pole = Console.ReadLine();
            Console.WriteLine("Выберите страну");
            string country = Console.ReadLine();
            Console.WriteLine("Выберите Овощ");
            string vegetables = Console.ReadLine();
            Console.WriteLine("Выберите время полива");
            string poliv = Console.ReadLine();
            Console.WriteLine("Выберите культуру");
            string culture = Console.ReadLine();

            Console.WriteLine("Поле: {0}, Страна: {1}, Овощ: {2}, Время Полива: {3}, Культура: {4}", pole, country, vegetables, poliv, culture);
        }

        public static void Update()
        {
            Console.WriteLine("Редакт поле");
            string pole1 = Console.ReadLine();
            Console.WriteLine("Редакт страну");
            string country2 = Console.ReadLine();
            Console.WriteLine("Редакт Овощ");
            string vegetables3 = Console.ReadLine();
            Console.WriteLine("Редакт время полива");
            string poliv4 = Console.ReadLine();
            Console.WriteLine("Редакт культуру");
            string culture5 = Console.ReadLine();

            Console.WriteLine("Редактировано Поле: {0}, Редактирована Страна: {1}, Редактирована Овощ: {2}, Редактирована Время Полива: {3}, Редактирована Культура: {4}", pole1, country2, vegetables3, poliv4, culture5);
        }

        public static void Search()
        {

        }

        public static void Delete()
        {
           
        }
    }
}
