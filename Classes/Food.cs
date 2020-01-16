using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moduleWork.Classes
{
    class Food
    {
        private int calories;
        FoodType foodType;
        string name;
        public Food(string name, int calories, FoodType foodType)
        {
            this.calories = calories;
            this.foodType = foodType;
            this.name = name;
        }

        public int GetCalories()
        {
            return this.calories;
        }
        public FoodType GetFoodType()
        {
            return this.foodType;
        }
        public string GetName()
        {
            return this.name;
        }
    }
}
