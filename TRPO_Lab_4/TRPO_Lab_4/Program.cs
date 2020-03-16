using System;
using System.IO;
namespace TRPO_Lab_4
{
    class Program
    {
        /// <summary>
        /// В процедуре реализовано считывание входных данных из файла, также
        /// создается объект типа фабрика для определенной страны, в зависимости от входных данных,
        /// затем вызванные из классов методы выводят информацию о параметрах страны в консоль
        /// </summary>
        static void Main(string[] args)
        {
            try
            {
                string country;
                FileStream inputFile = new FileStream("/Users/evgenijbuss/Desktop/говнокоды/TRPO_Lab_4/TRPO_Lab_4/input.txt", FileMode.Open);
                StreamReader reader = new StreamReader(inputFile);
                country = reader.ReadLine();
                reader.Close();
                AppFactory factory = null;
                if (country == "Germany")
                    factory = new GermanApp();
                else if (country == "Russia")
                    factory = new RussianApp();
                else if (country == "China")
                    factory = new ChineseApp();
                else throw new IOException();
                Console.Write("Region: ");
                factory.SetRegion().ShowRegion();
                Console.Write("Language: ");
                factory.SetLanguage().ShowLan();
                Console.Write("Address: ");
                factory.SetAddress().ShowAddress();
                Console.Write("App name: ");
                factory.SetAppName().ShowAppName();
                Console.Write("Site link: ");
                factory.SetLink().ShowSite();
                Console.Write("E-mail: ");
                factory.SetMailAddress().ShowEmail();
                Console.Write("Phone number: ");
                factory.SetPhone().ShowPhone();
                Console.Write("Price: ");
                factory.SetPrice().ShowPrice();
                Console.Write("Currency: ");
                factory.SetCurrency().ShowCurr();
                Console.Write("Time-zone: ");
                factory.SetTimeZone().ShowTimeZone();
            }
            catch (IOException)
            {
                Console.WriteLine("Invalid input");
            }
            catch
            {
                Console.WriteLine("Input Error");
            }
        }
    }
}
