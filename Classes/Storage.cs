using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moduleWork.Classes
{
    class Storage
    {
        private Dictionary<Food, int> store;
        public Storage()
        {
            this.store = new Dictionary<Food, int>();
        }
        public void AddFood(Food food, int amount)
        {
            this.store.Add(food, amount);
        }
        public bool IsInStore(Food food)
        {
            if (this.store[food] > 0)
                return true;
            else
                return false;
        }
        public void SubstractFood(Food food)
        {
            int amount = this.store[food];
            if (amount > 0)
                amount--;
            else
                amount = 0;
            this.store[food] = amount;
        }
        public Dictionary<Food, int> GetStore()
        {
            return this.store;
        }
        public List<Food> GetFoodList()
        {
            return this.store.Keys.ToArray().ToList();
        }
    }
}
