using AutomationRegister.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationRegister.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;
        

        IWebElement register => driver.FindElement(By.XPath("//*[@id='header']/nav/div/div[2]/ul/li[2]/a"));

        IWebElement firstName => driver.FindElement(By.XPath("//*[@id='basicBootstrapForm']/div[1]/div[1]/input"));

        IWebElement lastName => driver.FindElement(By.XPath("//*[@id='basicBootstrapForm']/div[1]/div[2]/input"));

        IWebElement Address => driver.FindElement(By.XPath("//*[@id='basicBootstrapForm']/div[2]/div/textarea"));

        IWebElement EmailAddress => driver.FindElement(By.XPath("//*[@id='eid']/input"));

        IWebElement Phone => driver.FindElement(By.XPath("//*[@id='eid']/input"));

        IWebElement Gender => driver.FindElement(By.XPath("//*[@id='basicBootstrapForm']/div[5]/div/label[1]"));

        IWebElement Hobbies => driver.FindElement(By.XPath("//*[@id='checkbox2']"));

        IWebElement Languages => driver.FindElement(By.XPath("//*[@id='msdd']/div"));

        IWebElement Skills => driver.FindElement(By.XPath("//*[@id='Skills']"));

        IWebElement Country => driver.FindElement(By.XPath("//*[@id='countries']"));

        IWebElement DateOfBirth => driver.FindElement(By.XPath("//*[@id='basicBootstrapForm']/div[11]"));

        IWebElement Password => driver.FindElement(By.XPath("//*[@id='firstpassword']"));

        IWebElement ConfirmPassword => driver.FindElement(By.XPath("//*[@id='secondpassword']"));

        IWebElement Submit => driver.FindElement(By.XPath("//*[@id='submitbtn']"));




        public void ClickonRegister()
        {
            register.Click();
        }

        public void EnterFirstName()
        {
            firstName.SendKeys("Seun");
        }

        public void EnterLastName()
        {
            lastName.SendKeys("Odunlami");
        }

        public void EnterAddress()
        {
            Address.SendKeys("Hedgemans way");
        }

        public void EnterEmailAddress()
        {
            EmailAddress.SendKeys("seunlami@yahoo.com");
        }

        public void EnterPhoneNumber()
        {
            Phone.SendKeys("07930322233");
        }

        public void SelectGender()
        {
            Gender.Click();
        }

        public void SelectHobbies()
        {
            Hobbies.Click();
        }

        public void SelectLanguages()
        {
            Languages.Click();
        }

        public void SelectSkills()
        {
            Skills.Click();
        }

        public void SelectCountry()
        {
            Country.Click();
        }

        public void SelectDateOfBirth()
        {
            DateOfBirth.Click();
        }

        public void EnterPassword()
        {
            Password.SendKeys("mummymini");
        }

        public void EnterConfirmPassword()
        {
            ConfirmPassword.SendKeys("mummymini");
        }

        public void ClickOnSubmit()
        {
            Submit.Click();
        }

                
        
        
        



        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("http://demo.automationtesting.in/Register.html");
        }
        
    }
}
