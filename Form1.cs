using moduleWork.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moduleWork
{
    public partial class Form1 : Form
    {
        Zoo zoo;
        FormLogic formLogic;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formLogic = new FormLogic();
            timeTB.Text = "0:00";

            var storage = new Storage();
            var zoo = new Zoo(storage);

            var CornType = new FoodType("Corn");
            var MeatType = new FoodType("Meat");
            var BoneType = new FoodType("Bone");
            var PlantType = new FoodType("Planty");
            var FishType = new FoodType("Fish");

            var corn = new Food("corn", 100, CornType);
            var cow = new Food("cow", 120, MeatType);
            var chicken = new Food("chicken", 150, MeatType);
            var bone = new Food("bone", 100, BoneType);
            var grass = new Food("grass", 200, PlantType);
            var fish = new Food("fish", 180, FishType);

            var mammal1 = new Mammal("Misha", 300, 5, MeatType, BoneType);
            var fish1 = new Fish("Nemo", 1, 2, CornType, PlantType);
            var bird1 = new Bird("Chick", 2, 4, CornType, PlantType);
            var bird2 = new Bird("Levi", 15, 6, CornType, PlantType);
            var mammal2 = new Mammal("Pengin", 12, 7, FishType, CornType);
            var mammal3 = new Mammal("Tiger", 120, 3, MeatType, FishType, BoneType);
            var fish2 = new Fish("Karp", 3, 4, CornType, PlantType);

            zoo.AddAnimal(mammal1, mammal2, mammal3, bird1, bird2, fish1, fish2);

            this.zoo = zoo;
            
            storage.AddFood(corn, 10);
            storage.AddFood(cow, 4);
            storage.AddFood(chicken, 12);
            storage.AddFood(bone, 2);
            storage.AddFood(grass, 3);
            storage.AddFood(fish, 1);

            foreach(Animal animal in zoo.GetAnimals())
            {
                AnimalsLV.Items.Add(animal.GetName());
            }

            List<Food> keys = zoo.GetStorage().GetStore().Keys.ToArray().ToList();

            foreach (Food key in keys)
            {
                StorageLV.Items.Add(key.GetName());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Food foodToFeed = zoo.GetStorage().GetFoodList().First(m => m.GetName() == StorageLV.SelectedItems[0].Text);
            Animal animalToFeed = zoo.GetAnimals().First(m => m.GetName() == AnimalsLV.SelectedItems[0].Text);
            animalToFeed.Feed(foodToFeed);
        }

        private void CheckB_Click(object sender, EventArgs e)
        {
            CheckedLV.Items.Clear();
            int hours;
            int minutes;
            string text = timeTB.Text;
            var arr = text.Split(':');
            hours = int.Parse(arr[0]);
            minutes = int.Parse(arr[1]);
            var listHunger = zoo.CheckHunger(hours, minutes);
            foreach(Animal animal in listHunger)
            {
                CheckedLV.Items.Add(animal.GetName());
            }
        }
    }
}
