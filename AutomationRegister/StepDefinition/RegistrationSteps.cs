using AutomationRegister.PageObject;
using System;
using TechTalk.SpecFlow;

namespace AutomationRegister.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }

        [Given(@"I navigate to website")]
        public void GivenINavigateToWebsite()
        {
            registrationPage.NavigateToWebsite();
        }
        
        [Given(@"I click on register")]
        public void GivenIClickOnRegister()
        {
            registrationPage.ClickonRegister();
        }
        
        [Given(@"I enter first name")]
        public void GivenIEnterFirstName()
        {
            registrationPage.EnterFirstName();
        }
        
        [Given(@"I enter last name")]
        public void GivenIEnterLastName()
        {
            registrationPage.EnterLastName();
        }
        
        [Given(@"I enter address")]
        public void GivenIEnterAddress()
        {
            registrationPage.EnterAddress();
        }
        
        [Given(@"I enter email address")]
        public void GivenIEnterEmailAddress()
        {
            registrationPage.EnterEmailAddress();
        }
        
        [Given(@"I enter phone number")]
        public void GivenIEnterPhoneNumber()
        {
            registrationPage.EnterPhoneNumber();
        }
        
        [Given(@"I select my gender")]
        public void GivenISelectMyGender()
        {
            registrationPage.SelectGender();
        }
        
        [Given(@"I select my hobbies")]
        public void GivenISelectMyHobbies()
        {
            registrationPage.SelectHobbies();
        }


        [Given(@"I select my language")]
        public void GivenISelectMyLanguage()
        {
            registrationPage.SelectLanguages();
        }

        [Given(@"I select skills")]
        public void GivenISelectSkills()
        {
            registrationPage.SelectSkills();
        }
        
        [Given(@"I select country")]
        public void GivenISelectCountry()
        {
            registrationPage.SelectCountry();
        }
        
        [Given(@"I select date of birth")]
        public void GivenISelectDateOfBirth()
        {
            registrationPage.SelectDateOfBirth();
        }

        [Given(@"I enter password")]
        public void GivenIEnterPassword()
        {
            registrationPage.EnterPassword();
        }


        [Given(@"I confirm password")]
        public void GivenIConfirmPassword()
        {
            registrationPage.EnterConfirmPassword();
        }
        
        [When(@"I click on Submit button")]
        public void WhenIClickOnSubmitButton()
        {
            registrationPage.ClickOnSubmit();
        }
        
        [Then(@"I shouuld have completed the registration form")]
        public void ThenIShouuldHaveCompletedTheRegistrationForm()
        {
            ScenarioContext.Current.Pending();
        }
    }

    
}
