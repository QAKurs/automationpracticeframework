using AutomationPracticeFramework.Helpers;
using AutomationPracticeFramework.Pages;
using System;
using TechTalk.SpecFlow;

namespace AutomationPracticeFramework.Steps
{
    [Binding]
    public class MyAccountSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HomePage hp = new HomePage(Driver);
        [Given(@"user opens sign in page")]
        public void GivenUserOpensSignInPage()
        {
            ut.ClickOnElement(hp.signIn);
        }
        
        [Given(@"enters correct credentials")]
        public void GivenEntersCorrectCredentials()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user submits the login form")]
        public void WhenUserSubmitsTheLoginForm()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user will be logged in")]
        public void ThenUserWillBeLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
