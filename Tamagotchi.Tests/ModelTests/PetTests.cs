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
        public PetTests()
        {
            DBConfiguration.ConnectionString="server=localhost;user id=root;password=epicodus;port=3306;database=tamagotchi_test;";
        }
        
        // [TestMethod]
        // public void PetConstructor_CreatesInstanceOfPet_Pet()
        // {
        //     Pet newPet = new Pet("name", 100, 100);
        //     Assert.AreEqual(typeof(Pet), newPet.GetType());
        // }

        // [TestMethod]
        // public void PetConstructor_CheckPropertyValues_PetProperties()
        // {
        //     Pet newPet = new Pet("name", 100, 100);
        //     int testId = 1;
        //     int testFood = 100;
        //     int testLife = 100;
        //     Assert.AreEqual(testFood, newPet.Food);
        //     Assert.AreEqual(testId, newPet.Id);
        //     Assert.AreEqual(testLife, newPet.Life);
        //     ;
        // }

        [TestMethod]
        public void GetAll_ReturnsEmptyListFromDatabase_PetList()
        {
            // Arrange
            List<Pet> newPetList = new List<Pet> { };

            //Act
            List<Pet> result = Pet.GetAll();

            //Asset
            CollectionAssert.AreEqual(newPetList, result);
        }

        // [TestMethod]
        // public void GetAll_ReturnsPets_PetList()
        // {
        //     //Arrange
        //     string petName01 = "Tomi";
        //     string petName02 = "Loganchi";
        //     int petFoodPts01 = 100;
        //     int petFoodPts02 = 100;
        //     int petLifePts01 = 100;
        //     int petLifePts02 = 100;
        //     Pet newPet01 = new Pet(petName01, petFoodPts01, petLifePts01);
        //     Pet newPet02 = new Pet(petName02, petFoodPts02, petLifePts02);
        //     List<Pet> newPetList = new List<Pet> { newPet01, newPet02 };

        //     //Act
        //     List<Pet> result = Pet.GetAll();

        //     //Assert
        //     CollectionAssert.AreEqual(newPetList, result);
        // }

        // [TestMethod]
        // public void GetId_PetsInstantiateWithAnIdAndGetterReturns_Int()
        // {
        //     //Arrange
        //     string petName = "Boris";
        //     int petFoodPts01 = 100;
        //     int petLifePts01 = 100;
        //     Pet newPet = new Pet(petName, petFoodPts01, petLifePts01);

        //     //Act
        //     int result = newPet.Id;

        //     //Assert
        //     Assert.AreEqual(1, result);
        // }

        // [TestMethod]
        // public void Find_ReturnsCorrectPet_Pet()
        // {
        //     //Arrange
        //     string petName01 = "Tomi";
        //     string petName02 = "Loganchi";
        //     int petFoodPts01 = 100;
        //     int petFoodPts02 = 100;
        //     int petLifePts01 = 100;
        //     int petLifePts02 = 100;
        //     Pet newPet01 = new Pet(petName01, petFoodPts01, petLifePts01);
        //     Pet newPet02 = new Pet(petName02, petFoodPts02, petLifePts02);

        //     //Act
        //     Pet result = Pet.Find(2);

        //     //Assert
        //     Assert.AreEqual(newPet02, result);
        // }

        // [TestMethod]
        // public void FeedPet_AddsFiveLifePoints_Life()
        // {
        //     string petName01 = "Tomi";
        //     int petFoodPts01 = 100;
        //     int petLifePts01 = 100;
        //     Pet newPet01 = new Pet(petName01, petFoodPts01, petLifePts01);
        //     int testFedPet = 105;

        //     newPet01.FeedPet();

        //     Assert.AreEqual(testFedPet, newPet01.Life);

        // }

    }
}