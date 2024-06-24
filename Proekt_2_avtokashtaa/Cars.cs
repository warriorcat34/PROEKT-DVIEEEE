using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt_2_avtokashtaa
{
    internal class Cars
    {
        private string owner;
        private string carid;
        private string engineid;
        private string bodyid;
        private string brand;
        private int price;
        private int year;

        public string Owner { get { return owner; } set { owner = value; } }
        public string CarID { get { return carid; } set { carid = value; } }
        public string EngineID { get { return engineid; } set { engineid = value; } }
        public string Body { get { return bodyid; } set { bodyid = value; } }
        public string Brand { get { return brand; } set { brand = value; } }
        public int Price { get { return price; } set { price = value; } }
        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 2024)
                {
                    Console.WriteLine("Kolata ne e napravena oshtee!!!");
                }
                else
                {
                    year = value;
                }
            }
        }



        public static void Print(List<Cars> list)
        {

            foreach (var item in list)
            {
                Console.WriteLine($"OwnerID:{item.Owner,-0}CardID:{item.CarID,-5}EngineID:{item.EngineID,-10}BodyID:{item.Body,-15}Brand:{item.Brand,-20}Price:{item.Price,-25}Year of manufactur{item.Year,-30}");
            }

        }

        public void Print1()
        {
            Console.WriteLine($"OwenerID:{this.Owner,-0}CarID:{this.CarID,-5}EngineID:{this.EngineID,-10}BodyID:{this.Body,-15}Brand:{this.Brand,-20}Price:{this.Price,-25}Year of manufactur:{this.Year,-30}");
        }
        public static void FindCarBrand(List<Cars> list)
        {
            Console.Write("Na koq kola ima sprvaka????:");
            string curbrand = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Brand == curbrand)
                {
                    list[i].Print1();
                }
            }
        }


        public static void ActualicacionCar(List<Cars> list)
        {
            Console.Write("Da se aktualizira li kola? (y/n): ");
            string proceed = Console.ReadLine().ToLower();

            if (proceed == "y")
            {
                Console.Write("Napishi CarId na kolata, koqto iskash da aktualizirash: ");
                string carId = Console.ReadLine();
                Cars car = null;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].CarID == carId)
                    {
                        car = list[i];
                        break;
                    }
                }

                if (car != null)
                {
                    Console.WriteLine("Izberi informaciata, koqto iskash da aktualizirash:");
                    Console.WriteLine("1. Brand");
                    Console.WriteLine("2. CarID");
                    Console.WriteLine("3. Year");
                    Console.Write("Enter your choice (1-3): ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Novata marka na kolata???: ");
                            car.Brand = Console.ReadLine();
                            Console.WriteLine("Markata e uspeshno aktualizirana!!!.");
                            break;
                        case 2:
                            Console.Write("Novoto CarID???: ");
                            car.CarID = Console.ReadLine();
                            Console.WriteLine("CarID e uspeshno aktualiziran!!.");
                            break;
                        case 3:
                            Console.Write("Napishi novata godina na kolata: ");
                            car.Year = int.Parse(Console.ReadLine());
                            Console.WriteLine("Godinata e uspeshno aktualizirana!!.");
                            break;
                        default:
                            Console.WriteLine("NEVALIDNOOOO!!!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ne beshe namereno ID na kolataa.");
                }
            }
            else
            {
                Console.WriteLine("Ne bqha napraveni nikakvi aktualizacii.");
            }
        }

        public static void CalculateAge(List<Cars> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Nqma koli v sistemataa.");
                return;
            }

            int currentYear = 2024;
            var carAges = list.Select(car => currentYear - car.Year);
            double averageAge = carAges.Average();

            Console.WriteLine($"Average: {averageAge}");
        }

        public static void OldestCar(List<Cars> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Nqma koli v sistemataa.");
                return;
            }

            int currentYear = 2024;
            int oldestCarYear = list.Min(car => car.Year);
            int oldestCarAge = currentYear - oldestCarYear;

            Console.WriteLine($"Nai-starata kola e na {oldestCarAge} godinii.");
        }
    }
}

