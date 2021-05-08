using CloudCall.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CloudCall.PageObject
{
    class JohnLewisPage
    {
        public IWebDriver driver;
        public JohnLewisPage()
        {
            driver = WebHook.driver;
        }

        private By cookieBanner = By.XPath("//*[@id='pecr-cookie-banner-wrapper']/div/div[1]/div/div[2]/button[1]");
        private By browseProduct = By.Id("mobileSearch");
        private By clickSearch = By.XPath("//*[@id='mobile-search']/div/form/div/button");
        private By selectProduct = By.XPath("//*[@id='js-plp-body']/div[2]/div[3]/div[17]/section/div/div/a/img");
        private By selectMultipleQuantity = By.XPath("//*[@id='emwbis-anchor']/div[1]/div/button[2]");
        private By addToBasket = By.XPath("//*[@id='button--add-to-basket']");
        private By goToBasket = By.Id("minibasket-icon-anchor");
        private By deleteProduct = By.XPath("//*[@id='basket-quantity-form']/div[3]/div/div/div/button[1]");
        private By goToBasket2 = By.Id("minibasket-icon-anchor");
        private By cookiesCleared = By.XPath("//*[@id='pecr-cookie-banner-wrapper']/div/div[1]/div/div[1]");
        

        //This is where i clicked on the banner to accept the cookie
        public void CookieBanner()
        {
            driver.FindElement(cookieBanner).Click();
        }

        //i clicked in the search box and enetered the product i was looking for.
        //the product name can be changed to any other product name you are searching for.
        public void BrowseProduct()
        {
            driver.FindElement(browseProduct).Click();
            driver.FindElement(browseProduct).SendKeys("candles");
            
        }

       
        public void ClickSearch()
        {
            driver.FindElement(clickSearch).Click();
        }

        //product was selected
        public void SelectProduct()
        {
            driver.FindElement(selectProduct).Click();
        }

        //i picked 6 quantity of the product
        public void SelectMultipleQuantity()
        {
            for (int i = 0; i < 5; i++)
                driver.FindElement(selectMultipleQuantity).Click();
        }

        public void AddToBasket()
        {
            Thread.Sleep(5000);
            driver.FindElement(addToBasket).Click();
        }

        public void GoToBasket()
        {
            Thread.Sleep(5000);
            driver.FindElement(goToBasket).Click();
        }

        public void DeleteProduct()
        {
            Thread.Sleep(5000);
            for (int i = 6; i > 0; i--)
                //break;
                driver.FindElement(deleteProduct).Click();

        }

        public void ClearCookies()
        {
            
            driver.Manage().Cookies.DeleteAllCookies();
            Thread.Sleep(5000);
            driver.FindElement(goToBasket2).Click();
        }

        public bool CookiesCleared()
        {
            return driver.Url.Contains(@"https://www.johnlewis.com/basket");
        }


    }
}
