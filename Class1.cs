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
    public class Class1
    {
        [Test]
        public static void FirstTest()
        {
            int leftOver = 4 % 2;
            Assert.AreEqual(expected: 0, leftOver, message: "Something went wrog");
            Assert.IsTrue(0==leftOver, message: "Something went wrog");
        }
        [Test]
        public static void SecondTest()
        {
            DateTime currentTime = DateTime.Now;
            Assert.AreEqual(expected: 20, currentTime.Hour, message: "Something went wrog");
        }

        [Test]
        public static void Test3()
        {
            int leftOver = 995 % 3;
            Assert.AreEqual(expected: 0, leftOver, message: "Something went wrog");
        }

        [Test]
        public static void Test4()
        {
            DateTime currentTime = DateTime.Now;
            Assert.AreEqual(DayOfWeek.Wednesday, currentTime.DayOfWeek, message: "Something went wrog");
        }

        [Test]
        public static void Test5()
        {
            Thread.Sleep(5000);
        }

        [Test]
        public static void Test6()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://login.yahoo.com/";
            chrome.Manage().Window.Maximize();
            IWebElement inputField = chrome.FindElement(By.Id("login-username"));
            inputField.SendKeys("test");
            IWebElement nextButton = chrome.FindElement(By.CssSelector("#login-signin"));
            nextButton.Click();
            // chrome.Quit()
        }


    }
}
