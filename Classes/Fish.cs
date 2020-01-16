using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moduleWork.Classes
{
    class Fish : Animal
    {
        public Fish(string name, int weight, int years, params FoodType[] foodTypes) : base(name, weight, years, foodTypes)
        {
        }
        public override int FeedInn(int calories)
        {
            double res = (calories / 2 + this.getAge() - this.weight) * 0.4;
            return (int)Math.Round(res, 0);
        }
    }
}
