using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmingFeedingAppVersion1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> foodComsumedDaily = new List<int>();
            List<string> animal = new List<string>() { "Chicken", "Sheep", "Pig" };
            List<string> animalfood = new List<string>() { "ChickenFeed", "Pig Feed" };
            List<float> foodprice = new List<float>() { 33.50f, 23.90f };

            Console.WriteLine("------Animal Holder Testing--------\n");
            AnimalHolder testAH = new AnimalHolder("Chicken", "Rhode Island",new DateTime(2023,05,25));
            List<int> aN = new List<int>() { 0, 2 };

            
            Console.WriteLine(testAH.AnimalSummary(animal));                       
            Console.WriteLine(testAH.Animalalive());            
            Console.WriteLine(testAH.GenerateId());
            Console.WriteLine("------------------------------------");
            Console.WriteLine(testAH.CalculateWeeklyConsumption());
            
            
           
            Console.ReadLine();
        }
    }
}
