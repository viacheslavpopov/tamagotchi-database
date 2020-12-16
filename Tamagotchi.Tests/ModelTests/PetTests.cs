using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Tamagotchi.Models;

namespace Tamagotchi.Tests
{
    [TestClass]
    public class PetTests
    {
        [TestMethod]
        public void PetConstructor_CreatesInstanceOfPet_Pet()
        {
            Pet newPet = new Pet("name");
            Assert.AreEqual(typeof(Pet), newPet.GetType());
        }
        [TestMethod]
        public void PetConstructor_CheckPropertyValues_PetProperties()
        {
            Pet newPet = new Pet("name");
            int testId = 1;
            int testFood = 100;
            int testLife = 100;
            Assert.AreEqual(testFood, newPet.Food);
            Assert.AreEqual(testId, newPet.Id);
            Assert.AreEqual(testLife, newPet.Life);
            ;
        }
    }
}