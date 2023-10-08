using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AttheZoo
{
    public class Snake : Animals       //Class that represent snakes that inherit from the animal class.
    {
        public bool IsReptile {  get; set; } 

        public Snake(string name, int age, string species, string habitat, bool IsReptile) : base(name, age, species, habitat, false,"Rats", 16)
        {
            this.IsReptile = IsReptile;
        }

        public void Rattle()    //The first snake is a Rattlesnake. This method tells how the rattlesnake sounds.
        {
            Console.WriteLine($"rattlesound with its tail");
        }

        public void NoSound()   // This is a method for the anaconda. It tells the user that an anaconda does not have a specific sound.
        {
            Console.WriteLine($"{Name}s makes no sound");
        }

        public void Venomous()  //This method is used for the rattlesnake to tell the user that its very venomous. 
        {

            Console.WriteLine($"{Name}s are very venomous");
        }

        public void Hugs()  //This method is used for the anaconda and it tells the user that the anaconda hugs its victims to death.
        {
            Console.WriteLine($"{Name}s hugs its victims to death");

        }

        public class Anaconda : Snake  //Class that represent an anaconda that inherits from the snake class. 
        { 
            public Anaconda (string name, int age, string species, string habitat, bool IsReptile) : base(name, age, "Anaconda", habitat, false) 
            {
                this.IsReptile = IsReptile;
            }

          

            

            

        }
    }
}
