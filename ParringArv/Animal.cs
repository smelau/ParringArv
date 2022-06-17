using System;

namespace ParringArv
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Cuteness { get; set; }
        public bool IsDead { get; set; }
       
        public Random random = new Random();

        public Animal(string name, int age, double cuteness, bool isDead)
        {
            Name = name;
            Age = age;
            Cuteness = cuteness;
            IsDead = isDead;
        }

        public virtual void PrintAnimalInfo()
        {
            Console.WriteLine($"Name:     {Name}");
            Console.WriteLine($"Age:      {Age}");
            Console.WriteLine($"Cuteness: {Cuteness}");
            Console.WriteLine($"Is dead:  {IsDead}");
        }

        public virtual Animal Parring(Animal partner)
        {
            
            string Ordliste =
                System.IO.File.ReadAllText(@"\ordliste(1).txt");
            string[] Ord = Ordliste.Split('\n');
            
            
            var name = Ord[random.Next(Ord.Length)];
            

            var cuteness = Math.Round(random.NextDouble() * 10, 2);
            return new Animal(name, 0, cuteness, true);
        }
    }
}