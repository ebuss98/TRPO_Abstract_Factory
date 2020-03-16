using System;
namespace TRPO_Lab_4
{
    /// <summary>
    /// Фабрика для немецкой версии приложения, наследует абстрактную фабрику AppFactory.
    /// </summary>
    public class GermanApp : AppFactory
    {
        /// <summary>
        /// Переопределенный метод, устанавливающий язык в зависимости от входных данных
        /// </summary>
        /// <returns> Класс, содержащий метод, выводящий язык на экран</returns>
        public override Lang SetLanguage()
        {
            return new GermanLan();
        }
        /// <summary>
        /// Переопределенный метод, устанавливающий валюту в зависимости от входных данных
        /// </summary>
        /// <returns> Класс, содержащий метод, выводящий валюту на экран</returns>
        public override Curr SetCurrency()
        {
            return new GermanCurrency();
        }
        /// <summary>
        /// Переопределенный метод, устанавливающий ссылку на сайт в зависимости от входных данных
        /// </summary>
        /// <returns> Класс, содержащий метод, выводящий ссылку на экран</returns>
        public override Site SetLink()
        {
            return new GermanLink();
        }
        /// <summary>
        /// Переопределенный метод, устанавливающий часовой пояс в зависимости от входных данных
        /// </summary>
        /// <returns> Класс, содержащий метод, выводящий часовой пояс на экран</returns>
        public override Time_Zone SetTimeZone()
        {
            return new GermanTimeZone();
        }
        /// <summary>
        /// Переопределенный метод, устанавливающий номер телефона в зависимости от входных данных
        /// </summary>
        /// <returns> Класс, содержащий метод, выводящий телефон на экран</returns>
        public override Phone SetPhone()
        {
            return new GermanPhone();
        }
        /// <summary>
        /// Переопределенный метод, устанавливающий адрес почты в зависимости от входных данных
        /// </summary>
        /// <returns> Класс, содержащий метод, выводящий адрес почты на экран</returns>
        public override Mail SetMailAddress()
        {
            return new GermanEmail();
        }
        /// <summary>
        /// Переопределенный метод, устанавливающий адрес офиса в зависимости от входных данных
        /// </summary>
        /// <returns> Класс, содержащий метод, выводящий адрес офиса на экран</returns>
        public override Address SetAddress()
        {
            return new GermanAddress();
        }
        /// <summary>
        /// Переопределенный метод, устанавливающий регион приложения в зависимости от входных данных
        /// </summary>
        /// <returns> Класс, содержащий метод, выводящий регион на экран</returns>
        public override Region SetRegion()
        {
            return new GermanRegion();
        }
        /// <summary>
        /// Переопределенный метод, устанавливающий цену в зависимости от входных данных
        /// </summary>
        /// <returns> Класс, содержащий метод, выводящий цену на экран</returns>
        public override Price SetPrice()
        {
            return new GermanPrice();
        }
        /// <summary>
        /// Переопределенный метод, устанавливающий название приложения в зависимости от входных данных
        /// </summary>
        /// <returns> Класс, содержащий метод, выводящий название приложения на экран</returns>
        public override AppName SetAppName()
        {
            return new GermanAppName();
        }
    }
}
