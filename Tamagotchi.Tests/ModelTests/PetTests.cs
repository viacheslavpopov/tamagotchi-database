using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Tamagotchi.Models;

namespace Tamagotchi.Tests
{
    [TestClass]
    public class PetTests : IDisposable
    {
        public void Dispose()
        {
            Pet.ClearAll();
        }

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
            int testLife = 100;
            Assert.AreEqual(testId, newPet.Id);
            Assert.AreEqual(testLife, newPet.Life);
            ;
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_PetList()
        {
            // Arrange
            List<Pet> newPetList = new List<Pet> { };

            //Act
            List<Pet> result = Pet.GetAll();

            //Asset
            CollectionAssert.AreEqual(newPetList, result);
        }

        [TestMethod]
        public void GetAll_ReturnsPets_PetList()
        {
            //Arrange
            string petName01 = "Tomi";
            string petName02 = "Loganchi";
            Pet newPet01 = new Pet(petName01);
            Pet newPet02 = new Pet(petName02);
            List<Pet> newPetList = new List<Pet> { newPet01, newPet02 };

            //Act
            List<Pet> result = Pet.GetAll();

            //Assert
            CollectionAssert.AreEqual(newPetList, result);
        }

        [TestMethod]
        public void GetId_PetsInstantiateWithAnIdAndGetterReturns_Int()
        {
            //Arrange
            string petName = "Boris";
            Pet newPet = new Pet(petName);

            //Act
            int result = newPet.Id;

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectPet_Pet()
        {
            //Arrange
            string petName01 = "Tomi";
            string petName02 = "Loganchi";
            Pet newPet01 = new Pet(petName01);
            Pet newPet02 = new Pet(petName02);

            //Act
            Pet result = Pet.Find(2);

            //Assert
            Assert.AreEqual(newPet02, result);
        }

        [TestMethod]
        public void FeedPet_AddsFiveLifePoints_Life()
        {
            string petName01 = "Tomi";
            Pet newPet01 = new Pet(petName01);
            int testFedPet = 105;

            newPet01.FeedPet();

            Assert.AreEqual(testFedPet, newPet01.Life);
        }
    }
}