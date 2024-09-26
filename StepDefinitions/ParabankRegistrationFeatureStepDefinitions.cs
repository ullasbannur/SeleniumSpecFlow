using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class ParabankRegistrationFeatureStepDefinitions
    {
        private IWebDriver _driver;
        [Given(@"User is on home page of bank")]
        public void GivenUserIsOnHomePageOfBank()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

        }

        [Given(@"User clicks on register link")]
        public void GivenUserClicksOnRegisterLink()
        {
            _driver.FindElement(By.XPath("//a[normalize-space()='Register']")).Click();
        }

        [When(@"User enters ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersAndAndAndAndAndAndAndAndAndAnd(string firstname, string lastname, string address, string city, string state, string zip, string phone, string ssn, string username, string password, string confirm)
        {
            _driver.FindElement(By.XPath("//input[@id='customer.firstName']")).SendKeys(firstname);
            _driver.FindElement(By.XPath("//input[@id='customer.lastName']")).SendKeys(lastname);
            _driver.FindElement(By.XPath("//input[@id='customer.address.street']")).SendKeys(address);
            _driver.FindElement(By.XPath("//input[@id='customer.address.city']")).SendKeys(city);
            _driver.FindElement(By.XPath("//input[@id='customer.address.state']")).SendKeys(state);
            _driver.FindElement(By.XPath("//input[@id='customer.address.zipCode']")).SendKeys(zip);
            _driver.FindElement(By.XPath("//input[@id='customer.phoneNumber']")).SendKeys(phone);
            _driver.FindElement(By.XPath("//input[@id='customer.ssn']")).SendKeys(ssn);
            _driver.FindElement(By.XPath("//input[@id='customer.username']")).SendKeys(username);
            _driver.FindElement(By.XPath("//input[@id='customer.password']")).SendKeys(password);
            _driver.FindElement(By.XPath("//input[@id='repeatedPassword']")).SendKeys(confirm);
        }

        [When(@"User clicks register button")]
        public void WhenUserClicksRegisterButton()
        {
            _driver.FindElement(By.XPath("//input[@value='Register']")).Click();
        }

        [Then(@"User enters dashboard page")]
        public void ThenUserEntersDashboardPage()
        {
            Thread.Sleep(10000);
            _driver.Dispose();
            ////a[normalize-space()='Log Out']
            /////input[@name='username']
            /////input[@name='password']
            /////input[@value='Log In']
            
        }
    }
}
