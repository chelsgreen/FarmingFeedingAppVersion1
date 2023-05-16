using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmingFeedingAppVersion1
{
    class AnimalHolder
    {
        //attributes or fields
        private string species;
        private string breed;
        private bool statusOfAnimal;
        private DateTime dateOfBirth;
        private string id;
        private List<float> foodConsumedDaily;

        //methods and functions

        //constructs an animal holder object
        public AnimalHolder(string species, string breed, DateTime dateOfBirth)
        {
            this.species = species;
            this.breed = breed;
            this.dateOfBirth = dateOfBirth;

            //set bool of statusOfAnimal to true

            //initilise foodConsumedDaily List

            foodConsumedDaily = new List<float>();

        }

        public float CalculateTotalCost()
        {
            // calculate cost per kg

            //time cost per kg by animals weekly consumption


            return 0f;
        }

        public float CalculateWeeklyConsumption()
        {
            //calculate the last 7 days of food consumption

            //loop through the last seven items of the food consumed daily list

            //add each daily consumption to sum consumption varilable

            //return total weekly consumtion
            return 0f;
        }
        private void GenerateId()
        {
            //store the first letter of species
            //store the first letter of breed
            //set the counter value
            //store the year

            //generate an unique Id by adding thoes values together 

        }

        //adds the foodConsumedDaily to the dailyconsumption
        public void AddFoodConsumed(float dailyconsumption)
        {
            foodConsumedDaily.Add(dailyconsumption);

        }

        //returns a string containing all the infomation the user need to know
        public string AnimalSummary()
        {
            string summary = "";

            return summary;

        }

        public string ToString()
        {
            return "";
        }

    }
}
