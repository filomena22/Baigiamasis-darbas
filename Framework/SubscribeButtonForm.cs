using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
        public class SubscribeButtonForm
    {

        public static void EnterElPastoAdresas(string valueElPastoAdresas);
    {
        Common.SendKeys(Locators.SubscribeButtonForm.inputElPastoAdresas, valueElPastoAdresas);
      
      }
        public static void ClickCheckBox1button()
    {
        Common.ClickElement(Locators.SubscribeButtonForm.CheckBox1button);

    }

{
        public static void ClickCheckBox2button()
    {
        Common.ClickElement(Locators.SubscribeButtonForm.CheckBox2button);

    }

        public static void ClickPrenumeruotiButton()
    {
        Common.ClickElement(Locators.SubscribeButtonForm.CheckBox2button)

    }

}

}