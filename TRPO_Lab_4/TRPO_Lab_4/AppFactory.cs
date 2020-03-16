using System;
namespace TRPO_Lab_4
{
    /// <summary>
    /// класс абстрактной фабрики, содержащий классы для установки параметров в зависимости
    /// от страны
    /// </summary>
    public abstract class AppFactory
    {
        public abstract Lang SetLanguage();
        public abstract Curr SetCurrency();
        public abstract Site SetLink();
        public abstract Time_Zone SetTimeZone();
        public abstract Phone SetPhone();
        public abstract Mail SetMailAddress();
        public abstract Address SetAddress();
        public abstract Region SetRegion();
        public abstract Price SetPrice();
        public abstract AppName SetAppName();
    }
    /// <summary>
    /// Абстрактный класс, содержащий метод для вывода языка приложения на экран
    /// </summary>
    public abstract class Lang
    {
        public static string language;
        public abstract void ShowLan();
    }
    /// <summary>
    /// Абстрактный класс, содержащий метод для вывода валюты приложения на экран
    /// </summary>
    public abstract class Curr
    {
        public static string currency;
        public abstract void ShowCurr();
    }
    /// <summary>
    /// Абстрактный класс, содержащий метод для вывода ссылки на сайт приложения на экран
    /// </summary>
    public abstract class Site
    {
        public static string link;
        public abstract void ShowSite();
    }
    /// <summary>
    /// Абстрактный класс, содержащий метод для вывода часового пояса для приложения на экран
    /// </summary>
    public abstract class Time_Zone
    {
        public static string timeZone;
        public abstract void ShowTimeZone();
    }
    /// <summary>
    /// Абстрактный класс, содержащий метод для вывода телефона на экран
    /// </summary>
    public abstract class Phone
    {
        public static string phoneNumber;
        public abstract void ShowPhone();
    }
    /// <summary>
    /// Абстрактный класс, содержащий метод для вывода адреса почты приложения на экран
    /// </summary>
    public abstract class Mail
    {
        public static string emailAddress;
        public abstract void ShowEmail();
    }
    /// <summary>
    /// Абстрактный класс, содержащий метод для вывода адреса офиса  на экран
    /// </summary>
    public abstract class Address
    {
        public static string address;
        public abstract void ShowAddress();
    }
    /// <summary>
    /// Абстрактный класс, содержащий метод для вывода региона приложения на экран
    /// </summary>
    public abstract class Region
    {
        public static string region;
        public abstract void ShowRegion();
    }
    /// <summary>
    /// Абстрактный класс, содержащий метод для вывода цены на экран
    /// </summary>
    public abstract class Price
    {
        public static int price;
        public abstract void ShowPrice();
    }
    /// <summary>
    /// Абстрактный класс, содержащий метод для вывода названия приложения на экран
    /// </summary>
    public abstract class AppName
    {
        public static string appName;
        public abstract void ShowAppName();
    }
}
