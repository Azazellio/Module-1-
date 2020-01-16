using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moduleWork.Classes
{
    class Mammal : Animal
    {
        public Mammal(string name, int weight, int years, params FoodType[] foodTypes) : base(name, weight, years, foodTypes)
        {
        }
        public override int FeedInn(int calories)
        {
            double res = (calories / 2 + this.getAge() - this.weight * 0.1) * 0.5;
            return (int)Math.Round(res, 0);
        }
    }
}
