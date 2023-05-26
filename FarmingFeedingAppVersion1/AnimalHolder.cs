using System;
using System.Collections.Generic;
using System.Globalization;
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
        private int foodConsumed;
        int speciescounter = 1;
        private List<float> foodConsumedDaily;
        private object iD;

        //methods and functions

        //constructs an animal holder object
        public AnimalHolder(string species, string breed, DateTime dateOfBirth)

        //at this to public Animal Holder object   , DateTime dateOfBirth
        {
            this.species = species;
            this.breed = breed;
            this.dateOfBirth = dateOfBirth;
            
            


            //set bool of statusOfAnimal to true
            bool statusOfAnimal = true;
            //initilise foodConsumedDaily List

            foodConsumedDaily = new List<float>();

        }

        public float CalculateTotalCost(float costPerKg)
        {
           
            //times cost per kg by animals weekly consumption

            return CalculateWeeklyConsumption() * costPerKg;
        }



        public float CalculateWeeklyConsumption()
        {
            float sumConsumption = 0f;
            //calculate the last 7 days of food consumption
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Enter the amount of food consumed daily per grams");
                species = Console.ReadLine();

            }
            return foodConsumed;
            //loop through the last seven items of the food consumed daily list
            //add each daily consumption to sum consumption varilable
            for (int dailyConsumptionIndex = foodConsumedDaily.Count - 1; dailyConsumptionIndex > foodConsumedDaily.Count - 8; dailyConsumptionIndex--)
            {
                sumConsumption += foodConsumedDaily[dailyConsumptionIndex];
            }


            //return total weekly consumtion
            return sumConsumption;
        }

        //example of id
        public string GenerateId()
        {
            //store the first letter of species, the first two letters of the breed and as well as the DOB and what species has been entered
            string iD = species.Substring(0, 2).ToLower() + breed.Substring(0, 2).ToLower() + dateOfBirth.Year +speciescounter;
               
            //generate an unique Id by adding thoes values together      
            return "ID:"+$"{iD}\n";

           
        }
    


        public string Animalalive()
        {
            string status = "Status: Dead\n";
            if (statusOfAnimal == false)
            {
                status = "Status: Alive\n";
            }

            return status;
        }

        //adds the foodConsumedDaily to the dailyconsumption
        public void AddFoodConsumed(float dailyconsumption)
        {
            foodConsumedDaily.Add(dailyconsumption);

        }

        //returns a string containing all the infomation the user need to know

        public string AnimalSummary(List<string> animal)
        {
          
            string summary = $"Name:{species}\nBreed: {breed}\nDOB: {dateOfBirth.ToString("d", (new CultureInfo("es-ES")))}";



            return summary;
        }

        public string ToString()
        {
            return "";
        }

    }
}
