using AnimalShelter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace AnimalShelterUnitTests
{
    
    
    /// <summary>
    ///This is a test class for AnimalTest and is intended
    ///to contain all AnimalTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AnimalTest
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
        ///A test for Animal Constructor
        ///</summary>
        [TestMethod()]
        public void AnimalConstructorTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            AnimalTypes.animalTypes type = new AnimalTypes.animalTypes(); // TODO: Initialize to an appropriate value
            Animal target = new Animal(name, type);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            AnimalTypes.animalTypes type = new AnimalTypes.animalTypes(); // TODO: Initialize to an appropriate value
            Animal target = new Animal(name, type); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getImage
        ///</summary>
        [TestMethod()]
        public void getImageTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            AnimalTypes.animalTypes type = new AnimalTypes.animalTypes(); // TODO: Initialize to an appropriate value
            Animal target = new Animal(name, type); // TODO: Initialize to an appropriate value
            Bitmap expected = null; // TODO: Initialize to an appropriate value
            Bitmap actual;
            actual = target.getImage();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getName
        ///</summary>
        [TestMethod()]
        public void getNameTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            AnimalTypes.animalTypes type = new AnimalTypes.animalTypes(); // TODO: Initialize to an appropriate value
            Animal target = new Animal(name, type); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getName();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getSpecies
        ///</summary>
        [TestMethod()]
        public void getSpeciesTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            AnimalTypes.animalTypes type = new AnimalTypes.animalTypes(); // TODO: Initialize to an appropriate value
            Animal target = new Animal(name, type); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getSpecies();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getType
        ///</summary>
        [TestMethod()]
        public void getTypeTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            AnimalTypes.animalTypes type = new AnimalTypes.animalTypes(); // TODO: Initialize to an appropriate value
            Animal target = new Animal(name, type); // TODO: Initialize to an appropriate value
            AnimalTypes.animalTypes expected = new AnimalTypes.animalTypes(); // TODO: Initialize to an appropriate value
            AnimalTypes.animalTypes actual;
            actual = target.getType();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getSpecies
        ///</summary>
        [TestMethod()]
        public void getSpeciesTest1()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            AnimalTypes.animalTypes type = new AnimalTypes.animalTypes(); // TODO: Initialize to an appropriate value
            Animal target = new Animal(name, type); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getSpecies();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest1()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            AnimalTypes.animalTypes type = new AnimalTypes.animalTypes(); // TODO: Initialize to an appropriate value
            Animal target = new Animal(name, type); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getImage
        ///</summary>
        [TestMethod()]
        public void getImageTest1()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            AnimalTypes.animalTypes type = new AnimalTypes.animalTypes(); // TODO: Initialize to an appropriate value
            Animal target = new Animal(name, type); // TODO: Initialize to an appropriate value
            Bitmap expected = null; // TODO: Initialize to an appropriate value
            Bitmap actual;
            actual = target.getImage();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getName
        ///</summary>
        [TestMethod()]
        public void getNameTest1()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            AnimalTypes.animalTypes type = new AnimalTypes.animalTypes(); // TODO: Initialize to an appropriate value
            Animal target = new Animal(name, type); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getName();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getType
        ///</summary>
        [TestMethod()]
        public void getTypeTest1()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            AnimalTypes.animalTypes type = new AnimalTypes.animalTypes(); // TODO: Initialize to an appropriate value
            Animal target = new Animal(name, type); // TODO: Initialize to an appropriate value
            AnimalTypes.animalTypes expected = new AnimalTypes.animalTypes(); // TODO: Initialize to an appropriate value
            AnimalTypes.animalTypes actual;
            actual = target.getType();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for setImage
        ///</summary>
        [TestMethod()]
        public void setImageTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            AnimalTypes.animalTypes type = new AnimalTypes.animalTypes(); // TODO: Initialize to an appropriate value
            Animal target = new Animal(name, type); // TODO: Initialize to an appropriate value
            string animalImageName = string.Empty; // TODO: Initialize to an appropriate value
            target.setImage(animalImageName);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
