using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            var lastPlanets = new List<string> { "Uranus", "Neptune" };

            planetList.AddRange(lastPlanets);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);

            foreach (var planet in planetList)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine("These are the rocky planets");

            foreach (var planet in rockyPlanets)
            {
                Console.WriteLine(planet);
            }

            planetList.Remove("Pluto");

            var probes = new Dictionary<string, List<string>>();

            probes.Add("Venus", new List<string> { "Mariner", "Venera", "Kosmos", "MESSENGER" });
            probes.Add("Mars", new List<string> { "Pathfinder", "Odyssey", "Curiosity", "Perseverance" });
            probes.Add("Jupiter", new List<string> { "Voyager", "Pioneer", "New Horizons" });

            foreach (var (probe, planets) in probes)
            {
                Console.WriteLine(probe);
                foreach (var planet in planets)
                {
                    Console.WriteLine($"\t{planet}");
                }
            }

        }
    }
}
