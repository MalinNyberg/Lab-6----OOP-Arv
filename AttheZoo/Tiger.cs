using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttheZoo
{
    public class Tiger : Animals      // A class that represent a Tiger that inherit from the animal class
    {
        public bool IsPreditor {  get; set; }    //Additional property specifically for the tiger
        public Tiger(string name, int age, string species, string habitat, bool IsPreditor) : base(name, age, "Tiger", habitat, true, "Meat",20)
        {
            this.IsPreditor = IsPreditor;
        }

        public void Roar()        //Additional method for the tiger to make a sound.
        {
            Console.WriteLine($"Raaawwwrr");
        }

        
    }
}
