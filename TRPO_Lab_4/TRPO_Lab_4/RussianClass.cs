using System;
namespace TRPO_Lab_4
{
    public class RussianApp : AppFactory
    {
        public override Lang SetLanguage()
        {
            return new RussianLan();
        }
        public override Curr SetCurrency()
        {
            return new RussianCurrency();
        }
        public override Site SetLink()
        {
            return new RussianLink();
        }
        public override Time_Zone SetTimeZone()
        {
            return new RussianTimeZone();
        }
        public override Phone SetPhone()
        {
            return new RussianPhone();
        }
        public override Mail SetMailAddress()
        {
            return new RussianEmail();
        }
        public override Address SetAddress()
        {
            return new RussianAddress();
        }
        public override Region SetRegion()
        {
            return new RussianRegion();
        }
        public override Price SetPrice()
        {
            return new RussianPrice();
        }
        public override AppName SetAppName()
        {
            return new RussianAppName();
        }
    }
}
