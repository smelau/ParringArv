using System;

namespace ParringArv
{
    public class Cat : Animal
    {
        public string FhurStyle { get; set; }
        public int Life { get; set; }

        public Cat(string name, int age, double cuteness, bool isDead, string fhurStyle, int life) : base(name, age, cuteness, isDead)
        {
            FhurStyle = fhurStyle;
            Life = life;
        }

        public override void PrintAnimalInfo()
        {
            base.PrintAnimalInfo();
            Console.WriteLine($"Fhurstyle:    {FhurStyle}");
            Console.WriteLine($"LIge:         {Life}");
        }
    }
    
}