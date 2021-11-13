using first_coding.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace first_coding.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;

        [OneTimeSetUp]

        public void LoginAction()
        {
            driver = new ChromeDriver();

            //Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            //Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMpage(driver);
        }
        [OneTimeTearDown]

        public void CloseTestRun()
        {
            driver.Quit();
        }

    }
}
