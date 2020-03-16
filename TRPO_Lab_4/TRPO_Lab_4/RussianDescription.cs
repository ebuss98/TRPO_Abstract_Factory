using System;
namespace TRPO_Lab_4
{
    class RussianLan : Lang
    {
        public override void ShowLan()
        {
            language = "Russian language";
            Console.WriteLine(language);
        }
    }

    class RussianCurrency : Curr
    {
        public override void ShowCurr()
        {
            currency = "Ruble";
            Console.WriteLine(currency);
        }
    }
    class RussianLink : Site
    {
        public override void ShowSite()
        {
            link = "www.bussapp.ru";
            Console.WriteLine(link);
        }
    }
    class RussianTimeZone : Time_Zone
    {
        public override void ShowTimeZone()
        {
            timeZone = "GMT+3";
            Console.WriteLine(timeZone);
        }
    }
    class RussianPhone : Phone
    {
        public override void ShowPhone()
        {
            phoneNumber = "+7-111-22-22";
            Console.WriteLine(phoneNumber);
        }
    }

    class RussianEmail : Mail
    {
        public override void ShowEmail()
        {
            emailAddress = "BussApp@mail.ru";
            Console.WriteLine(emailAddress);
        }
    }
    class RussianAddress : Address
    {
        public override void ShowAddress()
        {
            address = "Some russian address";
            Console.WriteLine(address);
        }
    }
    class RussianRegion : Region
    {
        public override void ShowRegion()
        {
            region = "Russia";
            Console.WriteLine(region);
        }
    }
    class RussianPrice : Price
    {
        public override void ShowPrice()
        {
            price = 1990;
            Console.WriteLine(price);
        }
    }
    class RussianAppName : AppName
    {
        public override void ShowAppName()
        {
            appName = "Russian app name";
            Console.WriteLine(appName);
        }
    }
}
