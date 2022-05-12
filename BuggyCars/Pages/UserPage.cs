using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BuggyCars.Pages
{
    internal class UserPage
    {
        public void CreateUserAccount(IWebDriver driver)
        {
            //Launch the Portal
            driver.Navigate().GoToUrl("https://buggy.justtestit.org/");

            // Click the Create User Button
            IWebElement createUserAccountButton = driver.FindElement(By.XPath("/html/body/my-app/header/nav/div/my-login/div/form/a"));
            createUserAccountButton.Click();
            Thread.Sleep(1000);

            // Click and enter a valid code
            IWebElement loginTextBox = driver.FindElement(By.Id("username"));
            loginTextBox.SendKeys("Test_00008");


            // Click and enter a valid name
            IWebElement firstNameTextbox = driver.FindElement(By.Id("firstName"));
            firstNameTextbox.SendKeys("Test_00008_Name");


            //Click and enter a valid lastname
            IWebElement lastNameTextbox = driver.FindElement(By.Id("lastName"));
            lastNameTextbox.SendKeys("Test_00008_Lastname");

            // click and enter a valid password
            IWebElement passwordTextbox= driver.FindElement(By.Id("password"));
            passwordTextbox.SendKeys("Test_00001_Pass");


            // click and enter a  confirm valid password
            IWebElement confirmPasswordTextbox = driver.FindElement(By.Id("confirmPassword"));
            confirmPasswordTextbox.SendKeys("Test_00001_Pass");
            Thread.Sleep(1000);

            
             // click Register button
             IWebElement registerButton = driver.FindElement(By.XPath("/html/body/my-app/div/main/my-register/div/div/form/button"));
             registerButton.Click();
             Thread.Sleep(1000);


             IWebElement alertLabel = driver.FindElement(By.XPath("/html/body/my-app/div/main/my-register/div/div/form/div[6]"));

             if (alertLabel.Text == "UsernameExistsException: User already exists")
             {
                    Console.Write("User already exist");
                    Thread.Sleep(1000);

             }
             else if (alertLabel.Text == "InvalidParameter: 1 validation error(s) found. - minimum field size of 6, SignUpInput.Password.")
             {
                 Console.Write("InvalidParameter: 1 validation error(s) found. - minimum field size of 6, SignUpInput.Password.");
                 Thread.Sleep(1000);

             }



             else


             {
                 Console.Write("User is created");
                 Thread.Sleep(1000);

             }
            
            












        }



    }
}
