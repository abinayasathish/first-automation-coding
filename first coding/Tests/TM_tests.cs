using first_coding.Pages;
using first_coding.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace first_coding
{
    [TestFixture]

    class TM_tests : CommonDriver 
    {
        

       

        [Test, Order(1)]

        public void CreateTMTest()
        {
            //TM page object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);

        }

        [Test, Order(2)]

        public void EditTMTest()
        {
            //Edit TM
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver);
        }

        [Test, Order(3)]

        public void DeleteTMTest()
        {
            //Delete TM
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver);
        }

       

            



    }
}

            
                
            
           

            
           
            


        
    







        

    
