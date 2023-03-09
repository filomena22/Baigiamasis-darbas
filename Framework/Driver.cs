

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Framework
{
    internal class Driver
    {
        private static IWebDriver driver;

        public static void SetupDriver()
        {
            driver = new ChromeDriver();
        }

        public static void QuitDriver()
        {
            driver.Quit();
        }

        internal static object GetDriver()
        {
            throw new NotImplementedException();
        }
    }

}
