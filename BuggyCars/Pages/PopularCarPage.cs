using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuggyCars.Utilities;
using System.Threading;

namespace BuggyCars.Pages
{
    internal class PopularCarPage
    {
        public void selectPopularMake(IWebDriver driver)
        {
            //Select Popular make
            IWebElement selectPopularMake = driver.FindElement(By.XPath("/html/body/my-app/div/main/my-home/div/div[1]/div/a/img"));
            selectPopularMake.Click();
            Thread.Sleep(2000);


        }


        public void createRankFirstComment(IWebDriver driver )
        {
            
            // Select Rank First  car  
            IWebElement selectRank1=driver.FindElement(By.XPath("/html/body/my-app/div/main/my-make/div/div[2]/div/div/table/tbody/tr[1]/td[2]/a"));
            selectRank1.Click();
            Thread.Sleep(1000);

            // Select the comment text box and type in comment  if Enabled 


            var element_visibility = driver.FindElements(By.Id("comment"));

            if (element_visibility.Count() > 0)
            {
                IWebElement selectRank1Comment = driver.FindElement(By.Id("comment"));
                selectRank1Comment.SendKeys("Test 007 comment 1");
               // Thread.Sleep(1000);


                // Click Vote Button
                IWebElement selectVoteButton = driver.FindElement(By.XPath("/html/body/my-app/div/main/my-model/div/div[1]/div[3]/div[2]/div[2]/div/button"));
                selectVoteButton.Click();
                Thread.Sleep(1000);

                // Assertion
                Console.Write("Thank you for voting!");



            }

            else
            {
                
               // driver.Manage().Window.Minimize();
                Console.WriteLine("You voted already!");
                Thread.Sleep(1000);


            }

            


            

        }


        public void createRankSecondComment(IWebDriver driver)
        {

            // Select the Rank second car 
            IWebElement selectRank2 = driver.FindElement(By.XPath("/html/body/my-app/div/main/my-make/div/div[2]/div/div/table/tbody/tr[2]/td[2]/a"));
            selectRank2.Click();
            Thread.Sleep(1000);





            // Select the comment text box and type in comment

            var  element_visibility = driver.FindElements(By.Id("comment"));

            if (element_visibility.Count() > 0)
            {

                IWebElement selectRank2Comment = driver.FindElement(By.Id("comment"));
                selectRank2Comment.SendKeys("Rank 2 Test_007");
                Thread.Sleep(1000);

                // Click the Vote Button

                IWebElement selectVoteButton = driver.FindElement(By.XPath("/html/body/my-app/div/main/my-model/div/div[1]/div[3]/div[2]/div[2]/div/button"));
                selectVoteButton.Click();
                Thread.Sleep(1000);

                // Assertion
                Console.Write("Thank you for voting!");


            }
            else
            {
                Console.WriteLine("You voted already!");
                Thread.Sleep(1000);

            }



        }

        public string getComment(IWebDriver driver)

        {
            IWebElement actualComment = driver.FindElement(By.XPath("/html/body/my-app/div/main/my-model/div/div[3]/table/tbody/tr[1]/td[3]"));
            return actualComment.Text;


        }

        public void createRankFirstCommentDataDriven(IWebDriver driver,  string Comment)
        {

            // Select Rank First  car  
            IWebElement selectRank1 = driver.FindElement(By.XPath("/html/body/my-app/div/main/my-make/div/div[2]/div/div/table/tbody/tr[1]/td[2]/a"));
            selectRank1.Click();
            Thread.Sleep(1000);

            // Select the comment text box and type in comment  if Enabled 


            var element_visibility = driver.FindElements(By.Id("comment"));

            if (element_visibility.Count() > 0)
            {
                IWebElement selectRank1Comment = driver.FindElement(By.Id("comment"));
               
                selectRank1Comment.SendKeys(Comment);
                // Thread.Sleep(1000);


                // Click Vote Button
                IWebElement selectVoteButton = driver.FindElement(By.XPath("/html/body/my-app/div/main/my-model/div/div[1]/div[3]/div[2]/div[2]/div/button"));
                selectVoteButton.Click();
                Thread.Sleep(1000);

                // Assertion
                Console.Write("Thank you for voting!");



            }

            else
            {

                // driver.Manage().Window.Minimize();
                Console.WriteLine("You voted already!");
                Thread.Sleep(1000);


            }






        }
    }
}
