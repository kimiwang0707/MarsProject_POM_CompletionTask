using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using SeleniumExtras.PageObjects;
using System.Threading;
//using OpenQA.Selenium.Support.PageObjects;
//using PageFactory = SeleniumExtras.PageObjects.PageFactory;

namespace MarsFramework.Pages
{
    class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }

        #endregion




        internal void LoginSteps()
        {
            //Populate excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignIn");

            // Wait Element
            GlobalDefinitions.WaitForElementClickable(GlobalDefinitions.driver, "XPath", "//a[contains(text(),'Sign')]", 10);

            // Click signin tab to signin page
            SignIntab.Click();

            // Input username
            Email.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Username"));

            // Input password
            Password.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            // Click Login button
            LoginBtn.Click();

            // Verify the login status
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "//*[contains(text(),'Kimi')]", 10);

            var loginName = GlobalDefinitions.driver.FindElement(By.XPath("//*[contains(text(), 'Kimi')]")).Text;
            Assert.That(loginName, Contains.Substring("Kimi"));
        }
    }
}