using CloudBeat.Frameworks.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace AIGExample
{
    [TestClass]
    public class AigExample : CBTest
    {
        [TestMethod]
        [Description("לינקים")]
        public void Links()
        {
            StartStep("דף הבית");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            _driver.Navigate().GoToUrl("https://www.aig.co.il/");
            _driver.Manage().Window.Maximize();
            EndStep("דף הבית");

            StartStep("אודות AIG ישראל");
            _driver.FindElement(By.XPath("//a[contains(text(),'אודות AIG ישראל')]")).Click();
            EndStep("אודות AIG ישראל");

            StartStep("כל הסיבות לבחור ב-AIG");
            Thread.Sleep(1000);
            _driver.FindElement(By.XPath("//a[contains(text(),'כל הסיבות לבחור ב-AIG')]")).Click();
            EndStep("כל הסיבות לבחור ב-AIG");

            StartStep("חברי הנהלה");
            Thread.Sleep(1000);
            _driver.FindElement(By.XPath("//a[contains(text(),'חברי הנהלה')]")).Click();
            EndStep("חברי הנהלה");

            StartStep("אמנת השירות");
            Thread.Sleep(1000);
            _driver.FindElement(By.XPath("//a[contains(text(),'אמנת השירות')]")).Click();
            EndStep("אמנת השירות");
        }

        [TestMethod]
        [Description("ביטוח רכב")]
        public void BituahRehev()
        {
            StartStep("דף הבית");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            _driver.Navigate().GoToUrl("https://www.aig.co.il/");
            _driver.Manage().Window.Maximize();
            EndStep("דף הבית");

            StartStep("ביטוח רכב");
            Thread.Sleep(1400);
            _driver.FindElement(By.XPath("(//a[@id='types_products_single_link']/div[2])[1]")).Click();
            EndStep("ביטוח רכב");

            StartStep("לחצו כאן להצעה אונליין");
            Thread.Sleep(1000);
            _driver.FindElement(By.XPath("//a[contains(text(),'לחצו כאן להצעה אונליין')]")).Click();
            EndStep("לחצו כאן להצעה אונליין");

            StartStep("לקבלת הצעה");
            Thread.Sleep(1000);
            _driver.FindElement(By.XPath("//button[@id='btn-get-offer']/span")).Click();
            EndStep("לקבלת הצעה");

            StartStep("הזנת פרטים");
            Thread.Sleep(1000);
            _driver.FindElement(By.Id("img-male")).Click();
            _driver.FindElement(By.Id("insuranceDate_1")).Click();
            _driver.FindElement(By.Id("firstName")).Click();
            _driver.FindElement(By.Id("firstName")).SendKeys("משה");
            Thread.Sleep(1500);
            _driver.FindElement(By.Id("lastName")).Click();
            _driver.FindElement(By.Id("lastName")).SendKeys("זוכמיר");
            EndStep("הזנת פרטים");

            StartStep("המשך");
            Thread.Sleep(1000);
            _driver.FindElement(By.Id("continue-btn")).Click();
            EndStep("המשך");

            StartStep("מספר טלפון");
            Thread.Sleep(1000);
            _driver.FindElement(By.Id("mobilePhone")).SendKeys("0544501591");
            EndStep("מספר טלפון");

            StartStep(" 2 המשך");
            Thread.Sleep(1000);
            _driver.FindElement(By.XPath("//button[@id='continue-btn']/span")).Click();
            EndStep(" 2 המשך");
        }

        [TestMethod]
        [Description("כניסה למערכת")]
        public void KnisaLeMaarehet()
        {
            StartStep("כניסה למערכת");

            StartStep("דף הבית");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            _driver.Navigate().GoToUrl("https://www.aig.co.il/");
            _driver.Manage().Window.Maximize();
            EndStep("דף הבית");

            StartStep("כניסה למבוטחים");
            _driver.FindElement(By.XPath("//*[@id=\"header-login-button\"]")).Click();
            EndStep("כניסה למבוטחים");

            StartStep("הזנת פרטים");
            _driver.FindElement(By.Id("custId")).SendKeys("317361723");
            _driver.FindElement(By.Id("custPhone")).SendKeys("0585160284");
            Thread.Sleep(3000);
            _driver.FindElement(By.XPath("//button[@id=\"btnLogin\"]")).Click();
            EndStep("הזנת פרטים");

            StartStep("ולידציה");
            _driver.FindElement(By.Id("non-existing-element")).Click();
            StartStep("ולידציה");

            EndStep("כניסה למערכת");
        }
    }
}
