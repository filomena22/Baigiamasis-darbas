using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class AddToCartButton
    {
        public static void ClickDovanuKuponaiButton()
        {
            Common.ClickElement(Locators.AddCartButton.DovanuKuponaiButton);


        }
        public static void ClickSelect10Button()
        {
            Common.ClickElement(Locators.AddToCartButton.Select10Button);

        }

        public static void ClickIKrepseliButton
        {
            Common.ClickElement(Locators.AddToCartButton.ClickIKrepseliButton);

        }
