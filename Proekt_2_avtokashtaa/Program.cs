using System.Collections.Generic;

namespace Proekt_2_avtokashtaa
{
    internal class Program
    {
        static List<Cars> list = new List<Cars>();
        static void Main(string[] args)
        {
            
            Console.Write("kolko koli????: ");
            int cars = int.Parse(Console.ReadLine());

            for (int i = 0; i < cars; i++) 
            {
                Cars kola = new Cars();
                Console.Write("Owner???: ");
                string owner = Console.ReadLine();
                kola.Owner = owner;
                Console.Write("ID na kolata???: ");
                string carID = Console.ReadLine();
                kola.CarID = carID;
                Console.Write("ID na engina???: ");
                string engineID = Console.ReadLine();
                kola.EngineID = engineID;
                Console.Write("ID na tqloto??: ");
                string body = Console.ReadLine();
                kola.Body = body;
                Console.Write("Markaa???: ");
                string Brand = Console.ReadLine();
                kola.Brand = Brand;
                Console.Write("Kolko struva kolata???: ");
                int price = int.Parse(Console.ReadLine());
                kola.Price = price;
                Console.Write("koq godina e napravena kolataa???: ");
                int year = int.Parse(Console.ReadLine());
                kola.Year = year;
                list.Add(kola);

            }

            Cars.Print(list);
            Cars.FindCarBrand(list);
            Cars.ActualicacionCar(list);
            Cars.CalculateAge(list);
            Cars.OldestCar(list);
        }
    }
}
