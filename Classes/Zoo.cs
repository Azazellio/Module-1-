using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moduleWork.Classes
{
    class Zoo
    {
        private List<Animal> animals;
        private Storage storage;
        private List<FoodType> foodTypesList;
        public Zoo(Storage storage)
        {
            this.storage = storage;
            this.animals = new List<Animal>();
        }
        public void FeedEm(Animal animal, Food food)
        {
            animal.Feed(food);
            storage.SubstractFood(food);
        }
        public List<Animal> CheckHunger(int hours, int minutes)
        {
            var timeToCheck = DateTime.Now.AddHours(hours);
            timeToCheck = timeToCheck.AddMinutes(minutes);
            var res = new List<Animal>();
            foreach(Animal animal in this.animals)
            {
                if (animal.WillBeHungry(timeToCheck))
                    res.Add(animal);
            }
            return res;
        }
        public void AddAnimal(Animal animal)
        {
            this.animals.Add(animal);
        }
        public void AddAnimal(params Animal[] animals)
        {
            foreach(Animal animal in animals)
            {
                this.animals.Add(animal);
            }
        }
        public List<Animal> GetAnimals()
        {
            return this.animals;
        }
        public Animal FindAnimalByName(string name)
        {
            return this.animals.First(n => n.GetName() == name);
        }
        public Storage GetStorage ()
        {
            return this.storage;
        }
    }
}
