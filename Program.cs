using System;
using System.Collections.Generic;

namespace galaxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var theGalaxies = new List<Galaxy>()
            {
                new Galaxy("Tadpole", 400),
                new Galaxy("Pinwheel", 25),
                new Galaxy("Milky Way", 0),
                new Galaxy("Andromeda", 3)
            };

            foreach (Galaxy i in theGalaxies)
            {
                Console.WriteLine("The " + i.Name + " galaxy is " + i.LightYears + " away!");
            }

            Console.ReadKey();

        }
    }

    public class Galaxy
    {
        public string Name { get; set; }
        public uint LightYears { get; set; }

        public Galaxy(string name, uint lightYears)
        {
            Name = name;
            LightYears = lightYears;
        }

    }

}