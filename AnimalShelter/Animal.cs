using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AnimalShelter
{
    /// <summary>
    /// This class is responsible for creating an animal, 
    /// given its name and animal type.
    /// </summary>
    class Animal:IAnimal
    {
        /// <summary>
        /// Declare the animal type and animal name 
        /// to be used.
        /// </summary>
        private const string IMAGE_DIRECTORY = "images/";
        private AnimalTypes.animalTypes type;
        private string name;
        private string animalImageName;

        /// <summary>
        /// Constructor - sets and initialises the name and 
        /// type of the animal to be created.
        /// </summary>
        /// <param name="name">The name of the animal.</param>
        /// <param name="type">The animal's type (species).</param>
        public Animal(string name, AnimalTypes.animalTypes type)
        {
            this.name = name;
            this.type = type;
        }

        /// <summary>
        /// This method returns the species of the 
        /// animal, by displaying the toString value
        /// of it's animal type.
        /// </summary>
        /// <returns>The type/species of the animal.</returns>
        public string getSpecies()
        {
            return type.ToString();
        }

        /// <summary>
        /// This method gets the name of the animal.
        /// </summary>
        /// <returns>The animal's name.</returns>
        public string getName()
        {
            return name;
        }

        /// <summary>
        /// This method obtains the animal's image, which
        /// is named like 'animalname.jpg'.
        /// </summary>
        /// <returns>The animal's image.</returns>
        public Bitmap getImage()
        {
            ///<summary>
            ///Get all .jpeg, .jpg, and .png images in images directory
            ///</summary>
            string[] imageFileNames = Directory.GetFiles("images/", "*.*", SearchOption.AllDirectories)
            .Where(s => s.EndsWith(".jpg") || s.EndsWith(".jpeg") || s.EndsWith(".png")).ToArray();

            for (int i = 0; i < imageFileNames.Count(); i++)
            {
                ///<summary>
                ///Obtain image file extension
                string extension = imageFileNames[i].Substring(imageFileNames[i].IndexOf('.'));

                ///<summary>
                ///Obtain animal name from image file
                ///(As name of image file should match name of animal).
                string animalName = imageFileNames[i].Substring(IMAGE_DIRECTORY.Length, imageFileNames[i].Length - (IMAGE_DIRECTORY.Length + extension.Length));

                ///<summary>
                ///If the animal name matches the animal 
                ///name obtained from the image, 
                ///set the animal image to the one found.
                if (getName() == animalName)
                {
                    setImage(imageFileNames[i]);
                }
            }

            ///<summary>
            ///Return the animal image obtained earlier.
            ///</summary>
            return new Bitmap(animalImageName);
        }

        /// <summary>
        /// This method sets the animal's image
        /// </summary>
        /// <param name="animalImageName">The name of the animal's image.</param>
        public void setImage(string animalImageName)
        {
            this.animalImageName = animalImageName;
        }

        /// <summary>
        /// This is an overriding toString method for the Animal object - 
        /// displaying its name and species/type.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return getName() + ": " + getSpecies();
        }


        /// <summary>
        /// This method gets the animal's type.
        /// </summary>
        /// <returns>The type associated with the animal.</returns>
        public AnimalTypes.animalTypes getType()
        {
            return type;
        }
    }
}
