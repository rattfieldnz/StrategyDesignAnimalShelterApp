using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Declare the animal manager to be used for the app.
        /// </summary>
        private AnimalManager animalManager;

        /// <summary>
        /// Declare the list of animals to be used in the app.
        /// </summary>
        private List<IAnimal> animals;

        /// <summary>
        /// Declare an array of listbixes to be used in the app.
        /// </summary>
        private PictureBox[] pictureBoxes;

        public Form1()
        {
            InitializeComponent();

            ///<summary>
            ///Initialise the animal manager with a file containing a list of animals, 
            ///and the listbox which they will be displayed in.
            ///</summary>
            animalManager = new AnimalManager("animalList.txt", showAnimalsLB);

            ///<summary>
            ///Initialise the array of PictureBoxes, and 
            ///fill it with the listboxes on the form.
            ///</summary>
            pictureBoxes = new PictureBox[4];
            pictureBoxes[0] = animal1PB;
            pictureBoxes[1] = animal2PB;
            pictureBoxes[2] = animal3PB;
            pictureBoxes[3] = animal4PB;

            ///<summary>
            ///Load the animals from the file
            ///</summary>
            animalManager.loadCritterList();

            ///<summary>
            ///Retrieve the list of animals which were
            ///loaded with the previous method call.
            ///</summary>
            animals = animalManager.getAnimalsList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the event handler for the "Show Pets!" button, 
        /// which displays the animals according to what radio button was checked, 
        /// and their type. 
        /// </summary>
        /// <param name="sender">Event handler sender.</param>
        /// <param name="e">Event handler argument.</param>
        private void showPetsBTN_Click(object sender, EventArgs e)
        {
            showAnimalsLB.Items.Clear();

            if (catsRB.Checked)
            {
                animalManager.addAnimalsToLBandImages(animals, AnimalTypes.animalTypes.Cat, pictureBoxes);
            }
            if (dogsRB.Checked)
            {
                animalManager.addAnimalsToLBandImages(animals, AnimalTypes.animalTypes.Dog, pictureBoxes);
            }
            if (ducksRB.Checked)
            {
                animalManager.addAnimalsToLBandImages(animals, AnimalTypes.animalTypes.Duck, pictureBoxes);
            }
            if (rabbitsRB.Checked)
            {
                animalManager.addAnimalsToLBandImages(animals, AnimalTypes.animalTypes.Rabbit, pictureBoxes);
            }
        }
    }
}
