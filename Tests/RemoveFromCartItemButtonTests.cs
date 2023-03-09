using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class RemoveFromCartItemButtonTests
    {
        [Test]
        public void RemoveFromCartItem()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.knygos.lt/";

            string valueEmail = "testerknygos@gmail.com";
            string valueSlaptazodis = "tester@22";

            string expectedText = "Jūsų prekių krepšelis tuščias"


            RemoveFromCartItem.ClickDovanuKuponaiButton();
            RemoveFromCartItem.Click20Button();
            RemoveFromCartItem.ClickIKrepseliButton();
            RemoveFromCartItem.ClickRecycleButton();

        }

        [TearDown]

        public void TearDown
        {

        Driver.QuitDriver();

        }
    }
}
