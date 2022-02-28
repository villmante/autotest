using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
namespace AutoTests
{
    public class ND01
    {

        [Test]
        public static void Sums1()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = " http://demo.seleniumeasy.com/basic-first-form-demo.html";
            Thread.Sleep(5000);
            IWebElement popUpNo = chrome.FindElement(By.Id("at-cv-lightbox-close"));
            popUpNo.Click();
            IWebElement inputFieldA = chrome.FindElement(By.CssSelector("#sum1"));
            inputFieldA.SendKeys("2");
            IWebElement inputFieldB = chrome.FindElement(By.CssSelector("#sum2"));
            inputFieldB.SendKeys("2");
            IWebElement nextButton = chrome.FindElement(By.CssSelector("#gettotal > button"));
            nextButton.Click();
            string total = chrome.FindElement(By.CssSelector("#displayvalue")).Text;
            inputFieldA.Clear();
            inputFieldB.Clear();
            Assert.AreEqual("4", total,  message: "Wrong calculation");
            chrome.Quit();
        }

        [Test]
        public static void Sums2()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = " http://demo.seleniumeasy.com/basic-first-form-demo.html";
            Thread.Sleep(5000);
            IWebElement popUpNo = chrome.FindElement(By.Id("at-cv-lightbox-close"));
            popUpNo.Click();
            IWebElement inputFieldA = chrome.FindElement(By.CssSelector("#sum1"));
            inputFieldA.SendKeys("-5");
            IWebElement inputFieldB = chrome.FindElement(By.CssSelector("#sum2"));
            inputFieldB.SendKeys("3");
            IWebElement nextButton = chrome.FindElement(By.CssSelector("#gettotal > button"));
            nextButton.Click();
            string total = chrome.FindElement(By.CssSelector("#displayvalue")).Text;
            inputFieldA.Clear();
            inputFieldB.Clear();
            Assert.AreEqual("-2", total,  message: "Wrong calculation");
            chrome.Quit();
        }

        [Test]
        public static void Sums3()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = " http://demo.seleniumeasy.com/basic-first-form-demo.html";
            Thread.Sleep(5000);
            IWebElement popUpNo = chrome.FindElement(By.Id("at-cv-lightbox-close"));
            popUpNo.Click();
            IWebElement inputFieldA = chrome.FindElement(By.CssSelector("#sum1"));
            inputFieldA.SendKeys("a");
            IWebElement inputFieldB = chrome.FindElement(By.CssSelector("#sum2"));
            inputFieldB.SendKeys("b");
            IWebElement nextButton = chrome.FindElement(By.CssSelector("#gettotal > button"));
            nextButton.Click();
            string total = chrome.FindElement(By.CssSelector("#displayvalue")).Text; 
            inputFieldA.Clear();
            inputFieldB.Clear();
            Assert.AreEqual("NaN", total,  message: "Wrong calculation");
            chrome.Quit();
        }
    }
}
