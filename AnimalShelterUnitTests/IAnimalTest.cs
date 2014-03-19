using AnimalShelter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace AnimalShelterUnitTests
{
    
    
    /// <summary>
    ///This is a test class for IAnimalTest and is intended
    ///to contain all IAnimalTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IAnimalTest
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
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        public void AnimalToStringTest()
        {
            IAnimal target = new Animal("Barry", AnimalTypes.animalTypes.Cat); 
            string expected = "Barry: Cat";
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for getImage
        ///</summary>
        [TestMethod()]
        public void getImageTest()
        {
            IAnimal target = new Animal("Bob", AnimalTypes.animalTypes.Cat); 
            Bitmap expected = target.getImage();
            Bitmap actual;
            actual = target.getImage();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for getName
        ///</summary>
        [TestMethod()]
        public void getNameTest()
        {
            IAnimal target = new Animal("Bob", AnimalTypes.animalTypes.Cat);
            string expected = "Bob";
            string actual;
            actual = target.getName();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for getSpecies
        ///</summary>
        [TestMethod()]
        public void getSpeciesTest()
        {
            IAnimal target = new Animal("Bob", AnimalTypes.animalTypes.Cat);
            string expected = "Cat";
            string actual;
            actual = target.getSpecies();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for getType
        ///</summary>
        [TestMethod()]
        public void getTypeTest()
        {
            IAnimal target = new Animal("Bob", AnimalTypes.animalTypes.Cat);
            AnimalTypes.animalTypes expected = AnimalTypes.animalTypes.Cat; // TODO: Initialize to an appropriate value
            AnimalTypes.animalTypes actual;
            actual = target.getType();
            Assert.AreEqual(expected, actual);
        }
    }
}
