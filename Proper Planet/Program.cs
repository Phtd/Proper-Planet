using System;
using System.Collections.Generic;
using System.Linq;

namespace Proper_Planet
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Planet> planets2 = PlanetCollection();


            planets2.Insert(1, new Planet()
            {
                PlaID = 2,
                PlaName = "Venus",
                PlaMass = 4.87,
                PlaDiameter = 12104,
                PlaDensity = 5243,
                PlaGravity = 8.9,
                PlaRotation = -5832.5,
                PlaLenghtOfDay = 2802.0,
                PlaToSunDistance = 108.2,
                PlaOrbitTime = 224.7,
                PlaVelocity = 35.0,
                PlaTemperature = 464,
                PlaMoonCount = 0,
                PlaRings = "No"
            });         // Inserts the planet venus into the list and places it on the 1st index(between "Merkur" and "Earth") on the list


            foreach (Planet planet in planets2)          // Foreach loop that will run through the list of planets
            {
                if (planet.PlaName == "Pluto")           // if statement that looks for the PlaName Pluto
                {
                    planets2.Remove(planet);             // if the "if" statement is true it will remove the found planet from the list
                    break;                               // Needs the break function, otherwise it will continue trying to find more on the list 
                }
            }

            planets2.Insert(1, new Planet()
            {
                PlaID = 9,
                PlaName = "Pluto",
                PlaMass = 0.0146,
                PlaDiameter = 2370,
                PlaDensity = 2095,
                PlaGravity = 0.7,
                PlaRotation = -153.3,
                PlaLenghtOfDay = 153.3,
                PlaToSunDistance = 5906.4,
                PlaOrbitTime = 90.56,
                PlaVelocity = 4.7,
                PlaTemperature = -225,
                PlaMoonCount = 5,
                PlaRings = "No"

            });     // Reinserts Pluto onto the list

            foreach (Planet aPlanet in planets2)
            {
                Console.WriteLine(aPlanet);
            }

            Console.WriteLine("There is " + planets2.Count + " elements on the list");      // Tells us, with the count function, how many elements is on the list

            List<MeanPlanet> meanPlanets = new List<MeanPlanet>();
           
           
           // foreach (Planet meanPlanet in planets2)                                       // Supposed to transfer from one list to another if value is true. 
           // {                                                                             // have to return to this later
           //     if (meanPlanet.PlaTemperature < 0)
           //     {                                                                                           
           //         meanPlanets.Add(planets2);
           //         Console.WriteLine("Planets with a mean temperature below 0 = " + meanPlanet.PlaName);
           //
           //     }
           // }
           

            
            //  planets2.Clear(); // Removes the whole list, by "clearing" the contents from the list
   
        }

        public static List<Planet> PlanetCollection()
        {
            //creates a list of the planets
            List<Planet> planets = new List<Planet>();

            //Adds the planets to the planet list
            planets.Add(new Planet()
            {
                PlaID = 1,
                PlaName = "Mercury",
                PlaMass = 0.330,
                PlaDiameter = 4879,
                PlaDensity = 5427,
                PlaGravity = 3.7,
                PlaRotation = 1407.6,
                PlaLenghtOfDay = 4222.6,
                PlaToSunDistance = 57.9,
                PlaOrbitTime = 88.0,
                PlaVelocity = 47.4,
                PlaTemperature = 167,
                PlaMoonCount = 0,
                PlaRings = "No"
            });                // Adds a planet to the list
            planets.Add(new Planet()
            {
                PlaID = 3,
                PlaName = "Earth",
                PlaMass = 5.97,
                PlaDiameter = 12756,
                PlaDensity = 5514,
                PlaGravity = 9.8,
                PlaRotation = 23.9,
                PlaLenghtOfDay = 24.0,
                PlaToSunDistance = 149.6,
                PlaOrbitTime = 365.2,
                PlaVelocity = 29.8,
                PlaTemperature = 15,
                PlaMoonCount = 1,
                PlaRings = "No"
            });                // Adds a planet to the list
            planets.Add(new Planet()
            {
                PlaID = 4,
                PlaName = "Mars",
                PlaMass = 0.642,
                PlaDiameter = 6792,
                PlaDensity = 3933,
                PlaGravity = 3.7,
                PlaRotation = 24.6,
                PlaLenghtOfDay = 24.7,
                PlaToSunDistance = 227.9,
                PlaOrbitTime = 687.0,
                PlaVelocity = 24.1,
                PlaTemperature = -65,
                PlaMoonCount = 2,
                PlaRings = "No"
            });                // Adds a planet to the list
            planets.Add(new Planet()
            {
                PlaID = 5,
                PlaName = "Jupiter",
                PlaMass = 1898,
                PlaDiameter = 142984,
                PlaDensity = 1326,
                PlaGravity = 23.1,
                PlaRotation = 9.9,
                PlaLenghtOfDay = 9.9,
                PlaToSunDistance = 778.6,
                PlaOrbitTime = 4331,
                PlaVelocity = 13.1,
                PlaTemperature = -110,
                PlaMoonCount = 67,
                PlaRings = "Yes"
            });                // Adds a planet to the list
            planets.Add(new Planet()
            {
                PlaID = 6,
                PlaName = "Saturn",
                PlaMass = 568,
                PlaDiameter = 120536,
                PlaDensity = 687,
                PlaGravity = 9.0,
                PlaRotation = 10.7,
                PlaLenghtOfDay = 10.7,
                PlaToSunDistance = 1433.5,
                PlaOrbitTime = 10747,
                PlaVelocity = 9.7,
                PlaTemperature = -140,
                PlaMoonCount = 62,
                PlaRings = "Yes"
            });                // Adds a planet to the list
            planets.Add(new Planet()
            {
                PlaID = 7,
                PlaName = "Uranus",
                PlaMass = 86.8,
                PlaDiameter = 51118,
                PlaDensity = 1271,
                PlaGravity = 8.7,
                PlaRotation = -17.2,
                PlaLenghtOfDay = 17.2,
                PlaToSunDistance = 2872.5,
                PlaOrbitTime = 30589,
                PlaVelocity = 6.8,
                PlaTemperature = -195,
                PlaMoonCount = 27,
                PlaRings = "Yes"
            });                // Adds a planet to the list
            planets.Add(new Planet()
            {
                PlaID = 8,
                PlaName = "Neptune",
                PlaMass = 102,
                PlaDiameter = 49528,
                PlaDensity = 1638,
                PlaGravity = 11.0,
                PlaRotation = 16.1,
                PlaLenghtOfDay = 16.1,
                PlaToSunDistance = 4495.1,
                PlaOrbitTime = 59.8,
                PlaVelocity = 5.4,
                PlaTemperature = -200,
                PlaMoonCount = 14,
                PlaRings = "Yes"
            });                // Adds a planet to the list
            planets.Add(new Planet()
            {
                PlaID = 9,
                PlaName = "Pluto",
                PlaMass = 0.0146,
                PlaDiameter = 2370,
                PlaDensity = 2095,
                PlaGravity = 0.7,
                PlaRotation = -153.3,
                PlaLenghtOfDay = 153.3,
                PlaToSunDistance = 5906.4,
                PlaOrbitTime = 90.56,
                PlaVelocity = 4.7,
                PlaTemperature = -225,
                PlaMoonCount = 5,
                PlaRings = "No"
            });                // Adds a planet to the list

            return planets;

        }
    }

    internal class MeanPlanet
    {
    }
}
