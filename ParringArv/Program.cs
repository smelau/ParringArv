using System;
using System.Collections.Generic;

namespace ParringArv
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Dog Bjarne = new Dog("Bjarne", 15, 2.1, false, "Puddel", "Svær");
            Dog Ida = new Dog("Ida", 4, 8.1, false, "Chihuahua", "Pitte liten");

            List<Animal> Dyr = new List<Animal>();
            Dyr.Add(Bjarne);
            Dyr.Add(Ida);
            Dyr.Add(Bjarne.Parring(Ida));




            foreach (var dyr in Dyr)
            {
                dyr.PrintAnimalInfo();
            }
        }
    }
}
