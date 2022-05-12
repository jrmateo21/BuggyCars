using BuggyCars.Pages;
using BuggyCars.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BuggyCars
{
    internal class Tests : CommonDriver
    {
        
        [SetUp]
        public void LoginFunction()
        {
            //open web browser.
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
          
            
        }

        [Test]
        public void CreateRankFirstComment_test()
        {

            // Call the login Page
            LoginPage loginPageObject = new LoginPage();
            loginPageObject.LogInSteps(driver);



           PopularCarPage popularCarPageObject = new PopularCarPage();
           popularCarPageObject.selectPopularMake(driver);
           popularCarPageObject.createRankFirstComment(driver);
          


        }


        [Test]
        public void CreateRankSecondComment_test()
        {

            // Call the login Page
            LoginPage loginPageObject = new LoginPage();
            loginPageObject.LogInSteps(driver);


            PopularCarPage popularCarPageObject = new PopularCarPage();
            popularCarPageObject.selectPopularMake(driver);
            popularCarPageObject.createRankSecondComment(driver);
            


        }
        [Test]
        public void CreateAccount_test()
        {
            // calling the UserPage
            UserPage userPageObject = new UserPage();
            userPageObject.CreateUserAccount(driver);

            


        }

        [TearDown]
        public void ClosedTestRun()
        {
            driver.Quit();
        }




    }
}