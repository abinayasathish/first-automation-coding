using first_coding.Pages;
using first_coding.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace first_coding
{
    [TestFixture]
    [Parallelizable]

    class TM_tests : CommonDriver 
    {
        

       

        [Test, Order(1), Description("Check if user is able to create a Time record with valid date")]

        public void CreateTMTest()
        {
            //Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMpage(driver);

            //TM page object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);

        }

        [Test, Order(2), Description("Check if user is able to edit an existing Time record")]

        public void EditTMTest()
        {
            //Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMpage(driver);

            //Edit TM
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver);
        }

        [Test, Order(3), Description("Check if user is able to delete the edited record")]

        public void DeleteTMTest()
        {
            //Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMpage(driver);

            //Delete TM
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver);
        }

       

            



    }
}

            
                
            
           

            
           
            


        
    







        

    
