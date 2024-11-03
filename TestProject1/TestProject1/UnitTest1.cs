using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace selenium
{
    public class Tests
    {
        private IWebDriver? driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(@"C:\Users\ruthp\OneDrive\Desktop\Testimine_\TestProject1\TestProject1\drivers\");
            driver.Navigate().GoToUrl("http://www.google.co.in");
        }

        [TearDown]
        public void Shutdown()
        {
            driver?.Dispose();
        }

        [Test]
        public void Should_SearchButton_Exist()
        {
            //pass
            var searchButton = driver.FindElement(By.Name("btnK"));
            Assert.NotNull(searchButton, "Search button should exist on the Google homepage.");
        }

        [Test]
        public void Should_Fail_NonexistentElement()
        {
            // fail
            var nonExistentElement = driver.FindElement(By.Id("nonexistent-id"));
            Assert.NotNull(nonExistentElement, "This element does not exist, so this test should fail.");
        }
    }
}
