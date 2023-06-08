﻿using FarmingFeedingAppVersion1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FarmingFeedingthisverson
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


            AnimalHolder testAH = new AnimalHolder( 1, (new DateTime(2023, 05, 25)));
            //AnimalHolder testAH = new AnimalHolder( new DateTime(2023, 05, 25));
            List<int> aN = new List<int>() { 0, 2 };



            Console.WriteLine(testAH.AnimalSummary(animal));
            Console.WriteLine(testAH.Animalalive());
            
            Console.WriteLine("------------------------------------");
            for (int i = 0; i < 7; i++)
            {

                Console.Write("Enter the amount of food consumed per grams for day {0}\n", i + 1);
                //foodConsumed = Convert.ToInt32(Console.ReadLine());
                testAH.AddFoodConsumed ( (float)Convert.ToDouble(Console.ReadLine()));

            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Total Amount of food consumed in the Week\n {testAH.CalculateWeeklyConsumption()}g");

            Console.WriteLine("----------------- Animal Manager Testing -----------------\n\n");

            AnimalManger am = new AnimalManger();

            am.AddAnimalHolder(testAH);

            Console.WriteLine(am.ConsumptionSummary());


            Console.ReadLine();
        }
    }
}



