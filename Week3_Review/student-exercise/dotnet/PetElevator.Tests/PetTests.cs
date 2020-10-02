using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetElevator.CRM;

namespace PetElevator.Tests
{
    [TestClass]
    public class PetTests
    {
        /*
         * The ListVaccinations method returns the elements of Vaccinations as a comma-delimited string.
         * For example, if the List contains ["Rabies", "Distemper", "Parvo"],
         * the output must be "Rabies, Distemper, Parvo".
         */
        [TestMethod]
        public void ListVaccinationsTest()
        {
            Pet pet = new Pet("Eiko", "Cockerspaniel");
            pet.Vaccinations = new List<string>() {"Rabies", "Distemper", "Parvo"};
            Assert.AreEqual("Rabies, Distemper, Parvo", pet.ListVaccinations());
        }
    }
}