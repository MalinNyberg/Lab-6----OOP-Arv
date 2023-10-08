using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AttheZoo
{
    public class Animals          //The base class of animals that all the other animals inherit from.
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }     // List of properties that the other animals inherit from.
        public string Habitat { get; set; }
        public bool IsMammal { get; set; }

        public string Food { get; set; }    
        public int SleepHoursPerDay {  get; set; }
        

        public Animals(string name, int age, string species, string habitat, bool ismammal, string food, int sleephoursperday)
        {
            Name = name;
            Age = age;
            Species = species;
            Habitat = habitat;                         //Constructor to create an animal-object with common properties.
            IsMammal = ismammal;
            Food = food;
            SleepHoursPerDay = sleephoursperday;

        }

        public void Animalinfo()                       //Common method to give some more info about the animals to the user.
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age} years");
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Habitat: {Habitat}");
            Console.WriteLine($"Is a mammal: {IsMammal}");
        }

        public void Eat()                                    //Common method that tells what the animals eat
        {
            Console.WriteLine($"{Name}s eats {Food} ");
            
        }

        public void Sleep()                                  //Common method that tells how the animals sleep
        {
            Console.WriteLine($"{Name}s sleeps up to {SleepHoursPerDay} hours per day");
        }

        public void MakeSound()                              //Common method for all animlas to be able to make a sound.
        {
            Console.WriteLine($"{Name}s make a sound that sounds like this:");
        }

     
    }

        
}
