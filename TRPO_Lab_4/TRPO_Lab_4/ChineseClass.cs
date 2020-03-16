using System;
namespace TRPO_Lab_4
{
    public class ChineseApp : AppFactory
    {
        public override Lang SetLanguage()
        {
            return new ChineseLan();
        }
        public override Curr SetCurrency()
        {
            return new ChineseCurrency();
        }
        public override Site SetLink()
        {
            return new ChineseLink();
        }
        public override Time_Zone SetTimeZone()
        {
            return new ChineseTimeZone();
        }
        public override Phone SetPhone()
        {
            return new ChinesePhone();
        }
        public override Mail SetMailAddress()
        {
            return new ChineseEmail();
        }
        public override Address SetAddress()
        {
            return new ChineseAddress();
        }
        public override Region SetRegion()
        {
            return new ChineseRegion();
        }
        public override Price SetPrice()
        {
            return new ChinesePrice();
        }
        public override AppName SetAppName()
        {
            return new ChineseAppName();
        }
    }
}
