using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetElevator.HR;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetElevator.Tests
{
   
    [TestClass]
    class CustomerTests
    {
        [TestMethod]
        public void CustomerGetBalanceTestDue()
        {
            Employee employee = new Employee("Foo", "Bar");
            Dictionary<string, double> services = new Dictionary<string, double>() { { "Walking", 10 },{ "Grooming", 10 },{ "Sitting", 10 } };
           
            Assert.AreEqual( 30,employee.GetBalanceDue(services));
        }
    }
}
