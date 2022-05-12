using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BuggyCars.Pages
{
    internal class LoginPage
    {
        public void LogInSteps(IWebDriver driver)
        {
            

            //Launch the Portal
            driver.Navigate().GoToUrl("https://buggy.justtestit.org/");

            // Identify Username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.XPath("/html/body/my-app/header/nav/div/my-login/div/form/div/input[1]"));
            usernameTextbox.SendKeys("Test_00007");

            // Identify password textbox and enter valid password.
            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/my-app/header/nav/div/my-login/div/form/div/input[2]"));
            passwordTextbox.SendKeys("Test_00001_Pass");

            // Click LoginButton
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/my-app/header/nav/div/my-login/div/form/button"));
            loginButton.Click();


            Thread.Sleep(5000);

            


                                                                                                                                                                                                                                                                                                                                  
        }


        //LoginSteps with Data Driven 

        public void LogInStepsDataDriven(IWebDriver driver,string Username, string Password)
        {


            //Launch the Portal
            driver.Navigate().GoToUrl("https://buggy.justtestit.org/");

            // Identify Username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.XPath("/html/body/my-app/header/nav/div/my-login/div/form/div/input[1]"));
            usernameTextbox.SendKeys(Username);

            // Identify password textbox and enter valid password.
            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/my-app/header/nav/div/my-login/div/form/div/input[2]"));
            passwordTextbox.SendKeys(Password);

            // Click LoginButton
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/my-app/header/nav/div/my-login/div/form/button"));
            loginButton.Click();

            Thread.Sleep(5000);

            

            





        }
    }
}
