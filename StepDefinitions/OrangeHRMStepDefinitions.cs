using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class OrangeHRMStepDefinitions
    {
        private IWebDriver _driver;


        [Given(@"User is on the orange hrm login page")]
        public void GivenUserIsOnTheOrangeHrmLoginPage()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }

        [When(@"User enters the ""([^""]*)"" and ""([^""]*)"" in the text fields")]
        public void WhenUserEntersTheAndInTheTextFields(string username, string password)
        {
            _driver.FindElement(By.XPath("//input[@placeholder='Username']")).SendKeys(username);

            _driver.FindElement(By.XPath("//input[@placeholder='Password']")).SendKeys(password);
        }

        [When(@"User clicks on the submit button")]
        public void WhenUserClicksOnTheSubmitButton()
        {
            _driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            Thread.Sleep(1000);
        }

        [Then(@"User is navigated to the home page")]
        public void ThenUserIsNavigatedToTheHomePage()
        {
            Thread.Sleep(1000);
            _driver.Dispose();
        }

        [Then(@"User is displayed with error message")]
        public void ThenUserIsDisplayedWithErrorMessage()
        {
            IWebElement error = _driver.FindElement(By.XPath(" //p[@class='oxd-text oxd-text--p oxd-alert-content-text']"));

            string errormsg = "Invalid credentials";
            Console.WriteLine(error.Text);
            Assert.AreEqual(errormsg, error.Text);
            Thread.Sleep(1000);
            _driver.Close();
        }

    }
}
