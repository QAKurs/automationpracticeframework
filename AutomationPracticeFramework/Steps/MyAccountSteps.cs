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
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.email, TestConstants.Username);
            ut.EnterTextInElement(ap.password, TestConstants.Password);
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

        [Given(@"initiates a flow for creating an account")]
        public void GivenInitiatesAFlowForCreatingAnAccount()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.email, ut.GenerateRandomEmail());
            ut.ClickOnElement(ap.createAcc);
        }

        [Given(@"user enters all required personal details")]
        public void GivenUserEntersAllRequiredPersonalDetails()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"submits the sign up form")]
        public void WhenSubmitsTheSignUpForm()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"user's full name is displayed")]
        public void ThenUserSFullNameIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"user is logged in")]
        public void GivenUserIsLoggedIn()
        {
            GivenUserOpensSignInPage();
            GivenEntersCorrectCredentials();
            WhenUserSubmitsTheLoginForm();
        }

    }
}
