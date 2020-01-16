using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moduleWork.Classes
{
    class Animal
    {
        private string name;
        private DateTime birth;
        protected int weight;
        private List<FoodType> foodTypes;
        private DateTime notHungryTo;
        public Animal(string name, int weight, int years, params FoodType[] foodtypes)
        {
            this.weight = weight;
            this.birth = DateTime.Now.AddYears(years * -1);
            this.foodTypes = new List<FoodType>(foodtypes.ToList());
            this.name = name;
        }
        public void Feed(Food food)
        {
            if (this.foodTypes.Contains(food.GetFoodType()))
            {
                int days = FeedInn(food.GetCalories());
                notHungryTo = DateTime.Now.AddDays(days);
            }
        }
        public virtual int FeedInn(int calories)
        {
            double res = (calories / 10 + this.getAge() - this.weight) * 1;
            return (int)Math.Round(res, 0);
        }
        public int getAge()
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            TimeSpan diff = DateTime.Now - birth;
            int years = (zeroTime + diff).Year - 1;
            return years;
        }
        public string GetName()
        {
            return this.name;
        }
        public bool WillBeHungry(DateTime time)
        {
            if (DateTime.Compare(this.notHungryTo, time) < 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
