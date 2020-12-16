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
            int testFood = 100;
            int testLife = 100;
            Assert.AreEqual(testFood, newPet.Food);
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

        // [TestMethod]
        // public void Find_ReturnsCorrectItem_Item()
        // {
        //   //Arrange
        //   string description01 = "Walk the dog";
        //   string description02 = "Wash the dishes";
        //   Item newItem1 = new Item(description01);
        //   Item newItem2 = new Item(description02);

        //   //Act
        //   Item result = Item.Find(2);

        //   //Assert
        //   Assert.AreEqual(newItem2, result);
        // }

    }
}