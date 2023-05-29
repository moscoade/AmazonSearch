using AmazonProductSearch.Drivers;
using AmazonProductSearch.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AmazonProductSearch.StepDefinitions
{
    [Binding]
    public class ProductSearchStepDefinitions
    {
        public IWebDriver driver = Hook.driver;
        ProductPage productPage = new ProductPage();

        [Given(@"I navigate to amazon website ""([^""]*)""")]
        public void GivenINavigateToAmazonWebsite(string Url)
        {
            driver.Navigate().GoToUrl(Url);
        }

        [Given(@"I click on change language")]
        public void GivenIClickOnChangeLanguage()
        {
            productPage.ChangeLanguage();
        }

        [Given(@"I select English")]
        public void GivenISelectEnglish()
        {
            productPage.selectEnglish();
        }


        [Given(@"I click on currency settings")]
        public void GivenIClickOnCurrencySettings()
        {
            productPage.ChangeCurrency();
        }

        [Given(@"I select British Pounds")]
        public void GivenISelectBritishPounds()
        {
            productPage.SelectBritihPounds();
        }

        [Given(@"I click on save change")]
        public void GivenIClickOnSaveChange()
        {
            productPage.SaveChange();

        }

        [Given(@"I enter in the Search field")]
        public void GivenIEnterInTheSearchField()
        {
            productPage.SearchField();
        }

        [Given(@"I click on search")]
        public void GivenIClickOnSearch()
        {
           productPage.ClickSearchBtn();
        }

        [Given(@"I select McAfee as brand")]
        public void GivenISelectMcAfeeAsBrand()
        {
           productPage.SelectBrand();
        }


        [Given(@"I enter minimum price range")]
        public void GivenIEnterMinimumPriceRange()
        {
            
        }

        [Given(@"I enter maximum Price range")]
        public void GivenIEnterMaximumPriceRange()
        {
            
        }

        [Given(@"I click on Go")]
        public void GivenIClickOnGo()
        {
            
        }

        [When(@"I select Window's oprating system Product")]
        public void WhenISelectWindowsOpratingSystemProduct()
        {
            
        }

        [Then(@"Window's compatibility product should be displayed")]
        public void ThenWindowsCompatibilityProductShouldBeDisplayed()
        {
            
        }
    }
}
