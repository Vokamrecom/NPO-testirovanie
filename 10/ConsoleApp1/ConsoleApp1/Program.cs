﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.by/");
            driver.FindElement(By.Name("q")).SendKeys("iTechArt");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

            //a)Finds the first result with the word
            IWebElement searchResultsA = driver.FindElement(By.XPath("//h3[contains(text(), 'iTechArt')]"));
            //b)Finds a title with the word "iTechArt". LC20lb - this is the class used by all Title on the search page
            IWebElement searchResultsB = driver.FindElement(By.XPath("//*[@class='LC20lb' and contains(text(), 'iTechArt')]"));

            // Print the text for every link in the search results.
            Console.WriteLine("a) Find link: " + searchResultsA.Text + "\n");
            Console.WriteLine("b) Find link: " + searchResultsB.Text);

        }
    }
}
