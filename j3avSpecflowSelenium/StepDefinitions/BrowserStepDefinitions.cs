using j3avSpecflowSelenium.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace j3avSpecflowSelenium.StepDefinitions
{
    [Binding]
    public sealed class BrowserStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        IWebDriver driver;
        private readonly ScenarioContext _scenarioContext;

        public BrowserStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("I navigate to j3av App on following environment")]
        public void GivenInavigatetoj3avApponfollowingenvironment(int number)
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            driver.Url = "https://lambdattest.github.io/sample-todo-app";
        }

        [Then(@"select the first item")]
        public void ThenSelectTheFirstItem()
        {
            // Click on First Check box
            driver.FindElement(By.Name("li1")).Click();
        }

        [Then(@"select the second item")]
        public void ThenSelectTheSecondItem()
        {
            // Click on Second Check box
            IWebElement secondCheckBox = driver.FindElement(By.Name("li2"));
            secondCheckBox.Click();
        }

        [Then(@"I enter new value in textbox")]
        public void ThenIenternewvalueintextbox()
        {
            // Enter Item name
            driver.FindElement(By.Id("sampletodotext")).SendKeys("sampletodotext");
        }

        [Then(@"click the Submit button")]
        public void ThenClickTheSubmitButton()
        {
            // Click on Add button
            IWebElement addButton = driver.FindElement(By.Id("addbutton"));
            addButton.Click();
        }

        [Then(@"verify whether the item is added to the list")]
        public void ThenVerifyWhetherTheItemIsAddedToTheList()
        {
            // Verified Added Item name
            //IWebElement itemtext = driver.FindElement(By.XPath("/html/body/div/div/div/form/input[1]"));
            //string getText = itemtext.Text;

            // Check if the newly added item is present or not using
            // Condition constraint (Boolean)
            //Assert.That(itemName.Contains(getText), Is.True);
            Assert.That(driver.FindElement(By.XPath("/html/body/div/div/div/form/input[1]")), Is.True);

            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Firefox - Test Passed");
        }

        [Then(@"close the browser instance")]
        public void ThenCloseTheBrowserInstance()
        {
            driver.Quit();
        }
    }
}