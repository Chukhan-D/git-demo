using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TA_HW_1_v2_
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.bbc.com");
            driver.FindElement(By.XPath("//div[@id='orb-nav-links']//li[@class='orb-nav-newsdotcom']/a")).Click();

            // IWebElement headline_news = driver.FindElement(By.XPath
            //     ("//div[@id='news-top-stories-container']//div[1]/div/a[@href='/news/world-asia-china-50541627']/h3"));
            System.Threading.Thread.Sleep(5000);
            IWebElement headline_news = driver.FindElement(By.XPath("//div[contains(@class,'gel-layout__item nw-c-top-stories__primary')]//div[contains (@class, 'gs-c-promo-body gs-u-display-none gs-u-display-inline-block@m gs-u-mt@xs')]//div/a[contains(@class,'gs-c-promo-heading')]/h3[contains(@class,'gs-c-promo-heading__title')]"));
            NUnit.Framework.Assert.AreEqual("Greenhouse gas concentrations break records", headline_news);

            driver.Close();
        }
    }
}
