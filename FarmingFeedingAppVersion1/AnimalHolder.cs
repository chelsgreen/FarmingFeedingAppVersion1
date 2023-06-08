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
        private int species;      
        private bool statusOfAnimal;
        private DateTime dateOfBirth;
        private int foodConsumed;
        int speciescounter = 1;
        private List<float> foodConsumedDaily;
        private string iD;
        private DateTime dateTime;
        private List<float> foodPrice = new List<float>() { 0.2f, 1.5f, 2f };

        //methods and functions



        //constructs an animal holder object
        public AnimalHolder(int species, DateTime dateOfBirth )

        
        {
            //this.species = species;
            this.species = species;
            this.dateOfBirth = dateOfBirth;

            //set bool of statusOfAnimal to true
            statusOfAnimal = true;
            
            //initilise foodConsumedDaily List
            foodConsumedDaily = new List<float>();

            //Generate id
          // GenerateId(speciesList);


        }

      
        public int GetSpecies()
        {
            return species;
        }


        public float CalculateTotalCost(float costPerKg)
        {
            // calculate cost per kg




            //time cost per kg by animals weekly consumption
            return CalculateWeeklyConsumption() * costPerKg;
            Console.WriteLine();
        }





        public float CalculateWeeklyConsumption()
        {

          
            float sumConsumption = 0;
            //calculate the last 7 days of food consumption

            //add each daily consumption to sum consumption varilable
            for (int dailyConsumptionIndex = foodConsumedDaily.Count - 1; dailyConsumptionIndex > foodConsumedDaily.Count - 8; dailyConsumptionIndex--)
            {
                sumConsumption += foodConsumedDaily[dailyConsumptionIndex];
            }



          
            //return total weekly consumtion
        
            return sumConsumption;
        }

        private float costOfFood(float price)
        {


            return CalculateWeeklyConsumption() * price;
        }


      
        public void GenerateId(List<string> speciesList)
        {
            //store the first letter of species, the first two letters of the breed and as well as the DOB and what species has been entered
            iD = speciesList[species].Substring(0, 2).ToLower() + dateOfBirth.Year + speciescounter;   
            //generate an unique Id by adding thoes values together
        }




        // Determines that the status is alive for animal at start of program
        public string Animalalive()
        {
            string status = "Status: Dead\n";
            if (statusOfAnimal == true)
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




        
        public string AnimalSummary(List<string> speciesList)
        {
            //returns a string containing all the infomation the user need to know 
            string summary = $"Name: {speciesList[species]}\nDOB: {dateOfBirth.ToString("d", (new CultureInfo("es-ES")))}";

            return summary;

        }


        public string ToString()
        {
            return "";
        }

    }



}