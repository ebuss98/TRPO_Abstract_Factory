using System;
namespace TRPO_Lab_4
{
    /// <summary>
    /// Класс, наследующий класс языка приложения, используется в фабрике для приложения
    /// немецкого региона
    /// </summary>
    class GermanLan : Lang
    {
        /// <summary>
        /// переопределенный метод, выводящий на экран язык текущей фабрики
        /// </summary>
        public override void ShowLan()
        {
            language = "German language";
            Console.WriteLine(language);
        }
    }
    class GermanCurrency : Curr
    {
        /// <summary>
        /// переопределенный метод, выводящий на экран валюту текущей фабрики
        /// </summary>
        public override void ShowCurr()
        {
            currency = "Euro";
            Console.WriteLine(currency);
        }
    }
    class GermanLink : Site
    {
        /// <summary>
        /// переопределенный метод, выводящий на экран ссылку на сайт текущей фабрики
        /// </summary>
        public override void ShowSite()
        {
            link = "www.bussapp.de";
            Console.WriteLine(link);
        }
    }
    class GermanTimeZone : Time_Zone
    {
        /// <summary>
        /// переопределенный метод, выводящий на экран часовой пояс текущей фабрики
        /// </summary>
        public override void ShowTimeZone()
        {
            timeZone = "GMT+1";
            Console.WriteLine(timeZone);
        }
    }
    class GermanPhone : Phone
    {
        /// <summary>
        /// переопределенный метод, выводящий на экран телефон текущей фабрики
        /// </summary>
        public override void ShowPhone()
        {
            phoneNumber = "+49-111-22-33";
            Console.WriteLine(phoneNumber);
        }
    }

    class GermanEmail : Mail
    {
        /// <summary>
        /// переопределенный метод, выводящий на экран адрес почты текущей фабрики
        /// </summary>
        public override void ShowEmail()
        {
            emailAddress = "BussApp@mail.de";
            Console.WriteLine(emailAddress);
        }
    }
    class GermanAddress : Address
    {
        /// <summary>
        /// переопределенный метод, выводящий на экран адрес текущей фабрики
        /// </summary>
        public override void ShowAddress()
        {
            address = "Some german address";
            Console.WriteLine(address);
        }
    }
    class GermanRegion : Region
    {
        /// <summary>
        /// переопределенный метод, выводящий на экран регион текущей фабрики
        /// </summary>
        public override void ShowRegion()
        {
            region = "Germany";
            Console.WriteLine(region);
        }
    }
    class GermanPrice : Price
    {
        /// <summary>
        /// переопределенный метод, выводящий на экран цену текущей фабрики
        /// </summary>
        public override void ShowPrice()
        {
            price = 1000;
            Console.WriteLine(price);
        }
    }
    class GermanAppName : AppName
    {
        /// <summary>
        /// переопределенный метод, выводящий на экран название приложения текущей фабрики
        /// </summary>
        public override void ShowAppName()
        {
            appName = "German app name";
            Console.WriteLine(appName);
        }
    }
}
