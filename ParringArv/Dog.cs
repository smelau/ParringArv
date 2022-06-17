using System;

namespace ParringArv
{
    public class Dog : Animal
    {
        public string Race { get; set; }
        public string Size { get; set; }

        public Dog(string name, int age, double cuteness, bool isDead, string race, string size) : base(name, age, cuteness, isDead)
        {
            Race = race;
            Size = size;
        }

        public override void PrintAnimalInfo()
        {
            base.PrintAnimalInfo();
            Console.WriteLine($"Race:     {Race}");
            Console.WriteLine($"Size:     {Size}");
            Console.WriteLine("*****************************");

        }
    }
}