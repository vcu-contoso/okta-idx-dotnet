﻿using FluentAssertions;
using embedded_auth_with_sdk.E2ETests.Drivers;
using OpenQA.Selenium;

namespace embedded_auth_with_sdk.E2ETests.PageObjectModels
{
    public class HomePage : BasePage
    {
        public HomePage(WebDriverDriver webDriverDriver, ITestConfiguration testConfiguration) : base(webDriverDriver, testConfiguration)
        { }

        public IWebElement LoginButton => _webDriver.FindElement(By.Id("LoginBtn"));
        public IWebElement LogoutButton => _webDriver.FindElement(By.Id("LogoutBtn"));
        public IWebElement RegisterButton => _webDriver.FindElement(By.Id("RegisterBtn"));
        public IWebElement ClaimUserNameLabel => _webDriver.FindElement(By.Id("claim-preferred_username"));
        public IWebElement ClaimGivenNameLabel => _webDriver.FindElement(By.Id("claim-given_name"));
        public IWebElement ClaimFamilyNameLabel => _webDriver.FindElement(By.Id("claim-family_name"));
        public IWebElement ClaimIdTokenLabel => _webDriver.FindElement(By.Id("claim-id_token"));
        public IWebElement ClaimAccessTokenLabel => _webDriver.FindElement(By.Id("claim-access_token"));

        public override string RelativePageUri => string.Empty;

        public override void AssertPageOpenedAndValid()
        {
            base.AssertPageOpenedAndValid();
            Title.Should().StartWith("Home Page");
        }
    }
}
