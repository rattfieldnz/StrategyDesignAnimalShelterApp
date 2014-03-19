using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace AnimalShelter
{
    /// <summary>
    /// This class is responsible for processing
    /// the animals for display on the form.
    /// </summary>
    class AnimalManager
    {
        /// <summary>
        /// Declaring necessary data for AnimalManager to initialise and use
        /// </summary>
        List<IAnimal> animals;
        ListBox animalListBox;
        string animalsListFile;

        /// <summary>
        /// Constructor - Initialises the declared data fields.
        /// </summary>
        /// <param name="animalsListFile">The name of the animal list file.</param>
        /// <param name="animalListBox">The ListBox to display the animals on.</param>
        public AnimalManager(string animalsListFile, ListBox animalListBox)
        {
            this.animalsListFile = animalsListFile;
            this.animalListBox = animalListBox;
            this.animals = new List<IAnimal>();
        }

        /// <summary>
        /// This method loads the animals from the animal list file, 
        ///  and adds them to a list of animals, 
        /// </summary>
        public void loadCritterList()
        {
            ///<summary>
            ///Clear any previous animals loaded.
            ///</summary>
            animalListBox.Items.Clear();

            ///<summary>
            ///Create a stream reader to read in the animals list file.
            ///</summary>
            StreamReader sr = null;

            ///<summary>
            ///If the file exists, add it to the stream reader, 
            ///, otherwise display an error.
            ///</summary>
            try
            {
                sr = new StreamReader(animalsListFile);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Can't find the input file!");
            }

            ///<summary>
            ///If the stream reader has read in the file, 
            ///iterate over each line and add the animal
            ///to the animals list initialised earlier.
            ///</summary>
            if (sr != null)
            {
                String currentLine = "";
                String[] currentAnimal;

                ///<summary>
                ///While there are still lines in the file, 
                ///split the current line according to its delimiter, 
                ///and use the data to add the animal to the animals list.
                while ((currentLine = sr.ReadLine()) != null)
                {
                    currentAnimal = currentLine.Split(',');

                    AnimalTypes.animalTypes currentSpecies = (AnimalTypes.animalTypes)System.Enum.Parse(typeof(AnimalTypes.animalTypes), currentAnimal[1]);
                    animals.Add(new Animal(currentAnimal[0], currentSpecies));
                } // end for each line
            } // end if sr != null
        } // end loadCritterList

        /// <summary>
        /// This method returns the list of animals.
        /// </summary>
        /// <returns>A list of animals.</returns>
        public List<IAnimal> getAnimalsList()
        {
            return animals;
        }

        /// <summary>
        /// This method is responsible for adding the animals to the listbox on the form, and their images to 4 listboxes
        /// (if there are 4 or less of the particular animal).
        /// </summary>
        /// <param name="animals">The list of animals to add to the listbox and pictureboxes.</param>
        /// <param name="type">The type of animal</param>
        /// <param name="pictureBoxes">An array of listboxes to add the animals' images to.</param>
        public void addAnimalsToLBandImages(List<IAnimal> animals, AnimalTypes.animalTypes type, PictureBox[] pictureBoxes)
        {
            ///<summary>
            ///Clear any previously added animals
            ///and pictures from the form.
            animalListBox.Items.Clear();

            foreach (PictureBox p in pictureBoxes)
            {
                p.Image = null;
            }

            List<IAnimal> displayImageAnimals = new List<IAnimal>();

            ///<summary>
            ///This loop goes through each animal currently in the list, 
            ///and adds the name + species of animal to the form listbox.
            ///<summary>
            for (int i = 0; i < animals.Count; i++ )
            {
                if (animals[i].getType() == type)
                {
                    animalListBox.Items.Add(animals[i].ToString());
                    displayImageAnimals.Add(animals[i]);
                }
            }

            ///<summary>
            ///If there are 4 or less animals in this list, 
            ///display each of their images to the form.
            ///</summary>
            if (displayImageAnimals.Count <= 4)
            {
                for (int i = 0; i < displayImageAnimals.Count; i++)
                {
                    pictureBoxes[i].Image = displayImageAnimals[i].getImage();
                }
            }
        }
    }
}
