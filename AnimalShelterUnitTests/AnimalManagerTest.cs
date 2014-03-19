using AnimalShelter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace AnimalShelterUnitTests
{
    
    
    /// <summary>
    ///This is a test class for AnimalManagerTest and is intended
    ///to contain all AnimalManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AnimalManagerTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for AnimalManager Constructor
        ///</summary>
        [TestMethod()]
        public void AnimalManagerConstructorTest()
        {
            string animalsListFile = string.Empty; // TODO: Initialize to an appropriate value
            ListBox animalListBox = null; // TODO: Initialize to an appropriate value
            AnimalManager target = new AnimalManager(animalsListFile, animalListBox);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for addAnimalsToLBandImages
        ///</summary>
        [TestMethod()]
        public void addAnimalsToLBandImagesTest()
        {
            string animalsListFile = string.Empty; // TODO: Initialize to an appropriate value
            ListBox animalListBox = null; // TODO: Initialize to an appropriate value
            AnimalManager target = new AnimalManager(animalsListFile, animalListBox); // TODO: Initialize to an appropriate value
            List<IAnimal> animals = null; // TODO: Initialize to an appropriate value
            AnimalTypes.animalTypes type = new AnimalTypes.animalTypes(); // TODO: Initialize to an appropriate value
            PictureBox[] pictureBoxes = null; // TODO: Initialize to an appropriate value
            target.addAnimalsToLBandImages(animals, type, pictureBoxes);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for getAnimalsList
        ///</summary>
        [TestMethod()]
        public void getAnimalsListTest()
        {
            string animalsListFile = string.Empty; // TODO: Initialize to an appropriate value
            ListBox animalListBox = null; // TODO: Initialize to an appropriate value
            AnimalManager target = new AnimalManager(animalsListFile, animalListBox); // TODO: Initialize to an appropriate value
            List<IAnimal> expected = null; // TODO: Initialize to an appropriate value
            List<IAnimal> actual;
            actual = target.getAnimalsList();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for loadCritterList
        ///</summary>
        [TestMethod()]
        public void loadCritterListTest()
        {
            string animalsListFile = string.Empty; // TODO: Initialize to an appropriate value
            ListBox animalListBox = null; // TODO: Initialize to an appropriate value
            AnimalManager target = new AnimalManager(animalsListFile, animalListBox); // TODO: Initialize to an appropriate value
            target.loadCritterList();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for addAnimalsToLBandImages
        ///</summary>
        [TestMethod()]
        public void addAnimalsToLBandImagesTest1()
        {
            string animalsListFile = string.Empty; // TODO: Initialize to an appropriate value
            ListBox animalListBox = null; // TODO: Initialize to an appropriate value
            AnimalManager target = new AnimalManager(animalsListFile, animalListBox); // TODO: Initialize to an appropriate value
            List<IAnimal> animals = null; // TODO: Initialize to an appropriate value
            AnimalTypes.animalTypes type = new AnimalTypes.animalTypes(); // TODO: Initialize to an appropriate value
            PictureBox[] pictureBoxes = null; // TODO: Initialize to an appropriate value
            target.addAnimalsToLBandImages(animals, type, pictureBoxes);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for getAnimalsList
        ///</summary>
        [TestMethod()]
        public void getAnimalsListTest1()
        {
            string animalsListFile = string.Empty; // TODO: Initialize to an appropriate value
            ListBox animalListBox = null; // TODO: Initialize to an appropriate value
            AnimalManager target = new AnimalManager(animalsListFile, animalListBox); // TODO: Initialize to an appropriate value
            List<IAnimal> expected = null; // TODO: Initialize to an appropriate value
            List<IAnimal> actual;
            actual = target.getAnimalsList();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for loadCritterList
        ///</summary>
        [TestMethod()]
        public void loadCritterListTest1()
        {
            string animalsListFile = string.Empty; // TODO: Initialize to an appropriate value
            ListBox animalListBox = null; // TODO: Initialize to an appropriate value
            AnimalManager target = new AnimalManager(animalsListFile, animalListBox); // TODO: Initialize to an appropriate value
            target.loadCritterList();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
