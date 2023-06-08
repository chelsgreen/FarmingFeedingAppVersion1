using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmingFeedingAppVersion1
{
    class AnimalManger
    {
        private List<AnimalHolder> animalHolders = new List<AnimalHolder>();
        private List<string> animal = new List<string>() { "Chicken", "Sheep", "Pig" };
        private List<float> foodPrices = new List<float>() {2f, 54.5f, 43 };
        public AnimalManger()
        {



        }
        //Calculates the total amount of food Consumed by the animal
        public List<float> TotalAmountOfFood()
        {
            
            List<float> totalConsumption = new List<float>() {0, 0, 0 };
            


            foreach (AnimalHolder animal in animalHolders)
            {
                //adds the total consumption to the weekly consumption
                totalConsumption[animal.GetSpecies()] += animal.CalculateWeeklyConsumption();
            }

            return totalConsumption;
        }
        public string ConsumptionSummary()
        {
            string summary = "";
            int indexcounter = 0;

            foreach (float speciesConsumption in TotalAmountOfFood())
            {
                //adds to list a the increase by one
                summary += $"{animal[indexcounter]}, {speciesConsumption}\n";
                indexcounter++;
            }
            //returns a summary of the total amount of the food consumed 
            return summary;
        }


        //ask user if the animal is still alive
        public string CheckAnimalsHealth()
        {
            return "";
        }
        public string HighestCostAnimal()
        {

            return "";
        }
        public List<float> CalculateSpeciesFeedCost()
        {
            List<float> speciesCost = new List<float>() { 0, 0, 0 };

            for (int i = 0; i < speciesCost.Count; i++)
            {
                speciesCost[i] += TotalAmountOfFood()[i]*foodPrices[i];
            }
            return speciesCost;
        }

        public void AddAnimalHolder(AnimalHolder newAnimal)
        {
            animalHolders.Add(newAnimal);
        }

    }
}
