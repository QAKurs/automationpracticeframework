using System;
using TechTalk.SpecFlow;

namespace AutomationPracticeFramework.Steps
{
    [Binding]
    public class MyAccountSteps
    {
        [Given(@"user opens sign in page")]
        public void GivenUserOpensSignInPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"enters correct credentials")]
        public void GivenEntersCorrectCredentials()
        {
            ScenarioContext.Current.Pending();
        }
        
        [StepDefinition(@"user submits the login form")]
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
