using CloudCall.Hooks;
using CloudCall.PageObject;
using FluentAssertions;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace CloudCall.Steps
{
    [Binding]
    public class JohnLewisSteps
    {
        public IWebDriver driver = WebHook.driver;
        JohnLewisPage jlp = new JohnLewisPage();
        

        [Given(@"Given User navigates to Johnlewis website")]
        public void GivenGivenUserNavigatesToJohnlewisWebsite()
        {
            driver.Navigate().GoToUrl("https://www.johnlewis.com/");
        }
        
        [Given(@"User accepts the cookie banner")]
        public void GivenUserAcceptsTheCookieBanner()
        {
            jlp.CookieBanner();
        }
        
        [Given(@"User browse for a product")]
        public void GivenUserBrowseForAProduct()
        {
            jlp.BrowseProduct();
            jlp.ClickSearch();
        }
        
        [Given(@"User select multiple quantities of the product")]
        public void GivenUserSelectMultipleQuantitiesOfTheProduct()
        {
            jlp.SelectProduct();
            jlp.SelectMultipleQuantity();
        }
        
        [Given(@"User add selected product to the basket")]
        public void GivenUserAddSelectedProductToTheBasket()
        {
            jlp.AddToBasket();
        }
        
        [Given(@"User delete the product quantities from basket")]
        public void GivenUserDeleteTheProductQuantitiesFromBasket()
        {
            jlp.GoToBasket();
            jlp.DeleteProduct();
        }
        
        [When(@"User clear cookies")]
        public void WhenUserClearCookies()
        {
            jlp.ClearCookies();
        }
        
        [Then(@"Cookies cleared should be displayed")]
        public void ThenCookiesClearedShouldBeDisplayed()
        {

            jlp.CookiesCleared().Should().BeTrue();
        }
    }
}
