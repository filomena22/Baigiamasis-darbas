using NUnit.Framework;
using OpenQA.Selenium;


namespace Tests
{
    internal class CartLoginTests
    {
        [Test]
        public void FormWithValidData()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.knygos.lt/";

            string valueElPastoAdresas = "testerknygos@gmail.com";
            string valueSlaptazodis = "tester@22";

            CartLogin.EnterElPastoAdresas(valueElPastoAdresas);
            CartLogin.EnterSlaptazodis(valueSlaptazodis);
            CartLogin.ClickPrisijungtiButton();


        }

        [TearDown]

        public void TearDown
        {

            Driver.QuitDriver();

        }
}

}

