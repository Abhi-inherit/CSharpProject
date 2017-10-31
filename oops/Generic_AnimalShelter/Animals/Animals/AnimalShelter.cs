using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class AnimalShelter<T>
    { 
        private T[] animalList;

        public AnimalShelter(int placesNumber)
        {
            animalList = new T[placesNumber]; // Initialization
            
        }
       

        AnimalShelter<T> dogsShelter = new AnimalShelter<T>();
        AnimalShelter<U> catsShelter = new AnimalShelter<U>();
    }
}
