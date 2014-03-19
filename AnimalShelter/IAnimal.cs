using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AnimalShelter
{
    /// <summary>
    /// This interface defines a set of behaviours
    /// required for each animal in the application 
    /// (that implements the interface).
    /// </summary>
    interface IAnimal
    {
        string getSpecies();
        string getName();
        Bitmap getImage();
        string ToString();
        AnimalTypes.animalTypes getType();
    }
}
