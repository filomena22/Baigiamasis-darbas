using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class SubscribeButtonFormTests
    {
        [Test]
        public void SubscribeFormButton()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.knygos.lt/"

            string valueElPastoAdresas = "testerknygos@gmail.com"
            string expectedText = "Beveik baigta..."


             SubscribeFormButton.InputValidElPastoAdresas(valueElPastoAdresas)
             SubscribeFormButton.ClickCheckBox1button
             SubscribeFormButton.SelectCheckBox2button
             SubscribeFormButton.ClickPrenumeruotiButton
        }

           [TearDown]

           public void TearDown
        {

            Driver.QuitDriver();

        }
     }
}
    

    

