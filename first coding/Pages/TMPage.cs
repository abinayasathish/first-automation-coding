﻿using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace first_coding.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // click on CreateNewbutton
            IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreateNewButton.Click();

            // click on TypeCode dropdown and select material
            IWebElement tmDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            tmDropdown.Click();
            Thread.Sleep(2000);


            IWebElement MaterialOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            MaterialOption.Click();

            // Enter code
            IWebElement CodeTextbox = driver.FindElement(By.Id("Code"));
            CodeTextbox.SendKeys("January19");

            // Enter Description
            IWebElement DescriptionTextbox = driver.FindElement(By.Id("Description"));
            DescriptionTextbox.SendKeys("January19");

            // Enter Price
            IWebElement PriceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            PriceTag.Click();

            IWebElement PriceTextbox = driver.FindElement(By.Id("Price"));
            PriceTextbox.SendKeys("$35.00");

            // Click on Save button
            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();
            Thread.Sleep(2000);


            // Click on go To Last Page Botton
            IWebElement goToLastPage_Botton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPage_Botton.Click();
            Thread.Sleep(2000);


            // Check if time record is present in the table has expected value
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement actualTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement actualPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            //1 option
            Assert.That(actualCode.Text == "January19", "actual code an expected code do not");
            Assert.That(actualTypeCode.Text == "M", "actual TypeCode an expected TypeCode do not");
            Assert.That(actualDescription.Text == "January19", "actual Description an expected Description do not");
            Assert.That(actualPrice.Text == "$35.00", "actual Price an expexted Price do not");
            

        }
        public void EditTM(IWebDriver driver)
        {
            IWebElement actual_Code = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            // Click EditButton
            IWebElement EditButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[last()]/a[1]"));
            EditButton.Click();

            // click on TypeCode dropdown and select time
            IWebElement tm_Dropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            tm_Dropdown.Click();
            Thread.Sleep(2000);


            IWebElement Time_Option = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            Time_Option.Click();

            //Clear the existing value of code
            IWebElement Code_Textbox = driver.FindElement(By.Id("Code"));
            Code_Textbox.Clear();

            //Edit the value of code
            Code_Textbox.SendKeys("January20");

            // Click on Save button
            IWebElement Save_Button = driver.FindElement(By.Id("SaveButton"));
            Save_Button.Click();
            Thread.Sleep(2000);


        }


        public void DeleteTM(IWebDriver driver)
        {
            // Delete the Edited Value by clicking Delete Button
            IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[4]/td[last()]/a[2]"));
            DeleteButton.Click();
            Thread.Sleep(2000);


            driver.SwitchTo().Alert().Accept();
            Console.WriteLine("Deleted Item Successfully");
        }

    }


    



            
    
}
