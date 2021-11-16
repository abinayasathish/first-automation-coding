using first_coding.Pages;
using first_coding.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace first_coding.Tests
{
    [TestFixture]
    [Parallelizable]

    class Employee_Test : CommonDriver
    {

        [Test, Order(1), Description("check if user is able to create a  Employee record")]

        public void CreateEmployeeTest()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployee(driver);

            //Employee page object initialization and definition
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.CreateEmployee(driver);

        }

        [Test, Order(2), Description("check if user ia able to edit an existing employee record")]

        public void EditEmployeeTest()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployee(driver);

            //Edit TM
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.EditEmployee(driver);
        }

        [Test, Order(3), Description("check if user is able to delete")]

        public void DeleteEmployeeTest()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployee(driver);

            //Delete TM
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.DeleteEmployee(driver);
        }


    }
}
