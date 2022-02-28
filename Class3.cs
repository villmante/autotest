using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoTests
{
    public class Class3
    {

        private static IWebDriver driver;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            driver = new ChromeDriver();
            driver.Url = "http://demo.seleniumeasy.com/basic-checkbox-demo.html";
            driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            driver.Quit();
        }

        [Test]
        public static void Test1OneCheckbox()
        {
            IWebElement resultElement = driver.FindElement(By.Id("txtAge"));
            ClickOnCheckbox(true);
            Assert.IsTrue("Success - Check box is checked".Equals(resultElement.Text), $"Text is not the same, actual text is {resultElement.Text}");

        }
        [Test]
        public static void Test2ManyCheckboxes()
        {
            ClickOnCheckbox(false);
            IReadOnlyCollection<IWebElement> checkboxes = driver.FindElements(By.CssSelector(".cb1-element"));
            foreach (IWebElement checkbox in checkboxes)
            {
                checkbox.Click();
            }
            IWebElement button = driver.FindElement(By.Id("check1"));
            //IWebElement button = driver.FindElement(By.CssSelector("#check1"));
            Assert.IsTrue("Uncheck All".Equals(button.GetAttribute("value")), "Text is not correct");
        }

        [Test]
        public static void Test3ManyCheckboxes()
        {
            ClickOnCheckbox(false);
  
            IWebElement button = driver.FindElement(By.Id("check1"));
            //IWebElement button = driver.FindElement(By.CssSelector("#check1"));
            Assert.IsTrue("Uncheck All".Equals(button.GetAttribute("value")), "Text is not correct");
        }

        private static void ClickOnCheckbox(bool shouldBeCheck)
        {
            IWebElement firstCheckbox = driver.FindElement(By.Id("isAgeSelected"));
            if (firstCheckbox.Selected != shouldBeCheck)
            {
                firstCheckbox.Click();
            }
        }

    }
}
