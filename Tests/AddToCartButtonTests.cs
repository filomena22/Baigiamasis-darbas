using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class AddToCartButtonTests
    {
        [Test]
        public void CheckForAddCart()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.knygos.lt/";

            string expectedResults = "10,00 €";

            AddToCartButton.ClickDovanuKuponaiButton();
            AddToCartButton.ClickSelect10Button();
            AddToCartButton.ClickIKrepseliButton();

        }

           [TearDown]

            public void TearDown
        {

            Driver.QuitDriver();

        }
    }
}
           