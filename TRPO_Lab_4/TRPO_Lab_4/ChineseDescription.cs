using System;
namespace TRPO_Lab_4
{
    class ChineseLan : Lang
    {
        public override void ShowLan()
        {
            language = "Chinese language";
            Console.WriteLine(language);
        }
    }
    class ChineseCurrency : Curr
    {
        public override void ShowCurr()
        {
            currency = "Renminbi";
            Console.WriteLine(currency);
        }
    }
    class ChineseLink : Site
    {
        public override void ShowSite()
        {
            link = "www.bussapp.cn";
            Console.WriteLine(link);
        }
    }
    class ChineseTimeZone : Time_Zone
    {
        public override void ShowTimeZone()
        {
            timeZone = "GMT+8";
            Console.WriteLine(timeZone);
        }
    }
    class ChinesePhone : Phone
    {
        public override void ShowPhone()
        {
            phoneNumber = "+86-111-22-33";
            Console.WriteLine(phoneNumber);
        }
    }

    class ChineseEmail : Mail
    {
        public override void ShowEmail()
        {
            emailAddress = "BussApp@mail.cn";
            Console.WriteLine(emailAddress);
        }
    }
    class ChineseAddress : Address
    {
        public override void ShowAddress()
        {
            address = "Some chinese address";
            Console.WriteLine(address);
        }
    }
    class ChineseRegion : Region
    {
        public override void ShowRegion()
        {
            region = "China";
            Console.WriteLine(region);
        }
    }
    class ChinesePrice : Price
    {
        public override void ShowPrice()
        {
            price = 1230;
            Console.WriteLine(price);
        }
    }
    class ChineseAppName : AppName
    {
        public override void ShowAppName()
        {
            appName = "Chinese app name";
            Console.WriteLine(appName);
        }
    }
}
