using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace TestSelenium
{
    public class Tests
    {
        //driver path
        string _path = Environment.CurrentDirectory + @"\Driver";
        //_driver
        IWebDriver _driver;        

        public Tests()
        {
            _driver = new ChromeDriver(_path);
            //navigate to url
            _driver.Navigate().GoToUrl("https://localhost:44361/");
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Login()
        {
            
            //details-button    
            Thread.Sleep(1000);
            IWebElement detailsButton = _driver.FindElement(By.Id("details-button"));
            detailsButton.Click();

            //proceed-link
            Thread.Sleep(1000);
            IWebElement proceedLink = _driver.FindElement(By.Id("proceed-link"));
            proceedLink.Click();

            //Login
            Thread.Sleep(1000);
            IWebElement acdeder = _driver.FindElement(By.LinkText("Login"));
            acdeder.Click();

            //User input
            IWebElement userInput = _driver.FindElement(By.Id("Input_Email"));
            userInput.SendKeys("prueba@gmail.com");

            //password input
            IWebElement password = _driver.FindElement(By.Id("Input_Password"));
            password.SendKeys("Erik1234.");

            //siguiente
            Thread.Sleep(1000);
            IWebElement siguiente = _driver.FindElement(By.Id("login-submit"));
            siguiente.Submit();

            Assert.Pass();
            
            
        }


    




    }
}