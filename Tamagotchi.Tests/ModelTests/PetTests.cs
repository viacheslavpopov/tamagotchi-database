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
            int testFood = 60;
            Assert.AreEqual(testFood, newPet.Food);
        }
    }
}