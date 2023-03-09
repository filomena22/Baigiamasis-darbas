
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

    public class CartLogin
{
    public static void EnterElPastoAdresas(string valueElPastoAdresas);
    {
    Common.SendKeys(Locators.CartLogin.inputElPastoAdresas,valueElPastoAdresas);

    }
    public static void EnterSlaptazodis(string valueSlaptazodis)
{
    Common.Sendkeys(Locators.CartLogin.inputSlaptazodis, valueSlaptazodis);

}

    public static void ClickPrisijungtiButton()
{
    Common.ClickElement(Locators.CartLogin.PrisijungtiButton);


}

}

}




     