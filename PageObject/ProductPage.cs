using AmazonProductSearch.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProductSearch.PageObject
{
    class ProductPage
    {
        public IWebDriver driver;

        private By language = By.XPath("//*[@class='icp-nav-link-inner']");
        private By engLanguage = By.XPath("(//*[@class='a-label a-radio-label'])[1]");
        private By currencyStg = By.XPath("//*[@class='a-button-text a-declarative']");
        private By BrtPound = By.XPath("//*[@id='icp-currency-dropdown_22']");
        private By save = By.XPath("(//*[@type='submit'])[2]");
        private By searchItems = By.XPath("//*[@type='text']");
        private By search = By.XPath("//*[@id=\"nav-search-submit-button\"]");
        private By brand = By.CssSelector("#p_89\\/McAfee > span > a > div > label > i");
       
        
        public ProductPage() 
        {
            driver = Hook.driver;
        }

        public void ChangeLanguage()
        {
            driver.FindElement(language).Click();
        }

        public void selectEnglish()
        {
            driver.FindElement(engLanguage).Click();
        }

        public void ChangeCurrency() 
        {
            driver.FindElement(currencyStg).Click();
        }

        public void SelectBritihPounds()
        {
            driver.FindElement(BrtPound).Click();
        }

        public void SaveChange() 
        {
            driver.FindElement(save).Click();
        }

        public void SearchField()
        {
            driver.FindElement(searchItems).Click();
           driver.FindElement(searchItems).SendKeys("Antivirus");
        }

        public void ClickSearchBtn()
        {
           driver.FindElement(search).Click();
        }

        public void SelectBrand()
        {
           driver.FindElement(brand).Click();
        }



    }
}
