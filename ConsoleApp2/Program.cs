using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();

            options.AddArgument("--disable-notifications");

            IWebDriver driver = new ChromeDriver(@"C:\Users\", options);

            Time();

            driver.Navigate().GoToUrl("https://theinnercircle.co/");

            Time();

            driver.Manage().Window.Maximize();

            Time();

            var entrar = driver.FindElement(By.XPath("/html/body/div[6]/div[1]/div[2]/div/div[2]"));

            entrar.Click();

            Time();

            var entrar1 = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/a[1]"));

            entrar1.Click();

            Time();

            driver.FindElement(By.Id("email")).SendKeys("user");

            driver.FindElement(By.Id("pass")).SendKeys("pass");

            Time();

            driver.FindElement(By.Id("loginbutton")).Click();

            for (int i = 0; i < 3000; i++)
            {
                Boolean isPresent = ExistsElement("/html/body/div[5]/div/a[2]");

                if (isPresent)
                {
                    var entrar3 = driver.FindElement(By.XPath("/html/body/div[5]/div/a[2]"));

                    entrar3.Click();

                    Time();
                }
                else
                {
                    var entrar2 = driver.FindElement(By.XPath("/html/body/div[1]/div[8]/div[3]/div[1]/div/div[1]/a[3]"));

                    entrar2.Click();

                    Time();
                }   
            }

            void Time()
            {
                Thread.Sleep(2000);
            }

            Boolean ExistsElement(String xpath)
            {
                try
                {
                    driver.FindElement(By.XPath(xpath));
                }
                catch (NoSuchElementException e)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
