using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
namespace AutoTests
{
    public class ND02
    {

        [Test]
        public static void Sums1()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.active.com/fitness/calculators/pace";
            Thread.Sleep(8000);
            //IWebElement popUpNo = chrome.FindElement(By.Id("at-cv-lightbox-close"));
            //popUpNo.Click();
            IWebElement inputFieldTimeH = chrome.FindElement(By.XPath("//*[@id='calculator-pace']/form/div[2]/div/label[1]/input"));
            inputFieldTimeH.SendKeys("1");

            IWebElement inputFieldTimeM = chrome.FindElement(By.XPath("//*[@id='calculator-pace']/form/div[2]/div/label[2]/input"));
            inputFieldTimeM.SendKeys("5");

            IWebElement inputFieldDistance = chrome.FindElement(By.XPath("//*[@id='calculator-pace']/form/div[3]/div/label/input"));
            inputFieldDistance.SendKeys("13");

            IWebElement distancetButton = chrome.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(3) > div > span > span"));
            distancetButton.Click();
            IWebElement kmButton = chrome.FindElement(By.XPath("//*[@id='calculator-pace']/form/div[3]/div/span/ul/li[1]"));
            kmButton.Click();

            IWebElement paceButton = chrome.FindElement(By.XPath("//*[@id='calculator-pace']/form/div[4]/div/span/span"));
            paceButton.Click();
            IWebElement kmPaceeButton = chrome.FindElement(By.XPath("//*[@id='calculator-pace']/form/div[4]/div/span/ul/li[1]"));
            kmPaceeButton.Click();

            IWebElement calculateButton = chrome.FindElement(By.XPath("/html/body/div[6]/div[5]/div[3]/div/div/div[2]/div/div/div[1]/div/form/div[6]/div/a"));
            calculateButton.Click();

            string total = chrome.FindElement(By.XPath("//*[@id='calculator-pace']/form/div[4]/div/label[2]/input")).Text;

            Assert.AreEqual("5", total, message: "Wrong calculation");
            chrome.Quit();
        }
    }
}
