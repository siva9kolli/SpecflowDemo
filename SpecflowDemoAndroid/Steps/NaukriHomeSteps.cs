using System.Drawing;
using NUnit.Framework;
using SpecflowDemoMac.Drivers;
using SpecflowDemoMac.Pages;
using TechTalk.SpecFlow;

namespace SpecflowDemoMac.Steps
{
    [Binding]
    public class NaukriHomeSteps : BaseAndroid
    {
       
       // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

       private readonly ScenarioContext _scenarioContext;
        public NaukriHomePage naukriHomePage;

       // public SauceDemoSteps(ScenarioContext scenarioContext)
       //{
       //    //_scenarioContext = scenarioContext;
       //}

       [Given("User open the android application")]
       public void UserOpenTheApplication()
       {
            naukriHomePage = new NaukriHomePage(androidDriver);
            naukriHomePage.IsProductsTilteDisplayed();
            System.Console.WriteLine("Application Launched");

        }

        [When("User scroll to login button and tap on it")]
        public void UserEnterCredentials()
        {
           // loginPage.login(Username, Password);
        }

       [When("User enter valid credentials")]
       public void UserClickOnLoginButton()
       {
            //loginPage.clickOnLoginButton();
       }

       [Then("Verify products page title")]
       public void VerifProductsPageTitle()
       {
          //  productsPage = new ProductsPage(driver);
           // Assert.IsTrue(productsPage.IsProductsTilteDisplayed());
            //Assert.IsFalse(false);
            //Assert.AreEqual(true);
            //Assert.AreSame("Test", "Test");
        }
    }
}
