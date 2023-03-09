using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class CopyCodeDiscountTests
    {
        [Test]
        public void CopyCodeDiscount()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.knygos.lt/";

            string expectedResults = "Liuks10";

            CopyCodeDiscount.ClickNuolaiduKuponaiButton();
            CopyCodeDiscount.ClickKopijuotiKodaButton();
            CopyCodeDiscount.ClickonSearchInput();
            CopyCodeDiscount.CopyPasteButton();


        }

        [TearDown]

        public void TearDown
        {

            Driver.QuitDriver();

        }
}

}
            


