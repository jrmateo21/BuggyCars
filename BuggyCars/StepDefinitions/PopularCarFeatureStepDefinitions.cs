using BuggyCars.Pages;
using BuggyCars.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace BuggyCars.StepDefinitions
{
    [Binding]
    public class PopularCarFeatureStepDefinitions : CommonDriver

    {
        LoginPage loginPageObject = new LoginPage();
        PopularCarPage popularCarPageObject = new PopularCarPage(); 
        




        [Given(@"I logged into buggy cars portal successfully")]
        public void GivenILoggedIntoBuggyCarsPortalSuccessfully()
        {

            // Open a new Chrome Browser and maximize it   
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Log in page Object Initialization and definition
            loginPageObject.LogInSteps(driver);


        }



        [When(@"I navigate to popular page")]
        public void WhenINavigateToPopularPage()
        {
            // Popular Car Page initialization and definition
            popularCarPageObject.selectPopularMake(driver);
          
        }


        [When(@"I navigate to first rank car then was able to  vote and comment")]
        public void WhenINavigateToFirstRankCarThenWasAbleToVoteAndComment()
        {
            popularCarPageObject.createRankFirstComment(driver);

        }

        [Then(@"Vote  and comment should be  recorded")]
        public void ThenVoteAndCommentShouldBeRecorded()
        {
            //PopularCarPage popularCarPageObject = new PopularCarPage();
            string postedComment = popularCarPageObject.getComment(driver);

            //Assertion
            Assert.That(postedComment == "Test 007 comment 1", "Actual comment and expected comment do not match");

           


           


        }


        //Comment and vote With data driven 

        [When(@"I navigate to first rank car then was able to  vote and '([^']*)'")]
        public void WhenINavigateToFirstRankCarThenWasAbleToVoteAnd(string p0)
        {
            popularCarPageObject.createRankFirstCommentDataDriven(driver, p0);
             
        }

        [Then(@"Voted  and '([^']*)' should be  recorded")]
        public void ThenVotedAndShouldBeRecorded(string p3)
        {

            string postedComment = popularCarPageObject.getComment(driver);
            Console.WriteLine(p3);
            Assert.That(postedComment == p3, "The actual comment and expected comment do not match");


        }


        // login user with data driven


        [Given(@"I  open the buggy cars  portal successfully")]
        public void GivenIOpenTheBuggyCarsPortalSuccessfully()
        {


            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();



        }

        [Then(@"I should be able to log in using '([^']*)' and '([^']*)'")]
        public void ThenIShouldBeAbleToLogInUsingAnd( string p0, string p1)
        {


            loginPageObject.LogInStepsDataDriven(driver, p0, p1);
            

                      
            

            
        

        }

        //End to End Testing - Regression

        

        [Given(@"I logged into buggy cars portal successfully with valid '([^']*)' and '([^']*)'")]
        public void GivenILoggedIntoBuggyCarsPortalSuccessfullyWithValidAnd(string p0, string p1)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //loginPageObject.LogInStepsDataDriven(driver, p0, p1);

        }




    }
}
