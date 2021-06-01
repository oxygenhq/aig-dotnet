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
        [Description("ביטוח נסיעות לחול")]
        public void AbroadTravelInsurance()
        {
            StartStep("ביטוח נסיעות לחול");

            StartStep("דף הבית");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            _driver.Navigate().GoToUrl("https://www.aig.co.il/");
            _driver.Manage().Window.Maximize();
            EndStep("דף הבית");

            StartStep("נסיעות לחול");
            _driver.FindElement(By.XPath("/html/body/div[1]/div[3]/main/div[1]/div/div/div/div[1]/div/div/div/div[2]/ul/li[4]/a/div[2]")).Click();
            EndStep("נסיעות לחול");

            StartStep("לחצו כאן למעבר לרכישת ביטוח נסיעות לחול אונליין");
            _driver.FindElement(By.XPath("//*[@title=\"לחצו כאן למעבר לרכישת ביטוח נסיעות לחול אונליין\"]")).Click();
            EndStep("לחצו כאן למעבר לרכישת ביטוח נסיעות לחול אונליין");

            StartStep("האם רכשת בעבר ביטוח נסיעות ");
            Thread.Sleep(2000);
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromMinutes(1));
            _driver.FindElement(By.XPath("//button[@id=\"closeBtn\"]")).Click();

            Thread.Sleep(2000);

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            try
            {
                _driver.FindElement(By.XPath("//button[@id=\"closeBtn\"]")).Click();
                Thread.Sleep(2000);
            } 
            catch (Exception)
            {
            }
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            EndStep("האם רכשת בעבר ביטוח נסיעות ");

            StartStep("אירופה");
            _driver.FindElement(By.Id("chkDestination156")).Click();
            EndStep("אירופה");

            StartStep("שוויץ");
            var el = _driver.FindElement(By.Id("chkDestination156"));
            el.Click();
            el.SendKeys("שוויץ");
            EndStep("שוויץ");

            StartStep("האם כל הנוסעים מגיל 16 ומעלה השלימו את הליך החיסון ");
            _driver.FindElement(By.Id("coronaVaccinatedBtnYes")).Click();
            EndStep("האם כל הנוסעים מגיל 16 ומעלה השלימו את הליך החיסון ");

            EndStep("ביטוח נסיעות לחול");
        }

        [TestMethod]
        [Description("שירות לקוחות ותביעות")]
        public void ShirutLakuhot()
        {
            StartStep("חיפוש מוסך - שירות לקוחות ותביעות");

            StartStep("דף הבית");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            _driver.Navigate().GoToUrl("https://www.aig.co.il/");
            _driver.Manage().Window.Maximize();
            EndStep("דף הבית");

            StartStep("שירות לקוחות ותביעות");
            _driver.FindElement(By.Id("menu-1117-link")).Click();
            EndStep("שירות לקוחות ותביעות");

            StartStep("איתור בעלי מקצוע");
            _driver.FindElement(By.XPath("//strong[text()=\"איתור בעלי מקצוע\"]")).Click();
            EndStep("איתור בעלי מקצוע");

            StartStep("איתור מוסכים ובעלי מקצוע");
            _driver.FindElement(By.XPath("//span[text()=\"איתור מוסכים ובעלי מקצוע\"]")).Click();
            EndStep("איתור מוסכים ובעלי מקצוע");

            StartStep("מוסכים");
            var sel = _driver.FindElement(By.Id("filter-garages-type"));
            var selectElement = new SelectElement(sel);
            selectElement.SelectByText("מוסכים");
            EndStep("מוסכים");

            StartStep("עיר");
            sel = _driver.FindElement(By.Id("filter-garages-city"));
            selectElement = new SelectElement(sel);
            selectElement.SelectByText("רמת השרון");
            EndStep("עיר");

            StartStep("התמחות");
            sel = _driver.FindElement(By.Id("filter-garages-murshe"));
            selectElement = new SelectElement(sel);
            selectElement.SelectByText("כללי");
            EndStep("התמחות");

            EndStep("חיפוש מוסך - שירות לקוחות ותביעות");
        }

        [TestMethod]
        [Description("כניסה למערכת")]
        public void KnisaLeMaarehet()
        {
            StartStep("כניסה למערכת");

            StartStep("דף הבית");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
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
