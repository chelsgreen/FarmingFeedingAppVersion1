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
        private List<float> foodPrice = new List<float>() { 0.2f, 1.5f, 2f };
        public AnimalManger()
        {
        }
    }
}
