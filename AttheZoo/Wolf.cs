using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace AttheZoo
{
    public class Wolf : Animals            //A class that represent a wolf that inherit from the Animal class
    {
        public bool IsPreditor { get; set; }  //Additional property for the Wolf
        public Wolf(string name, int age,string species, string habitat, bool IsPreditor): base(name, age, "Wolf", habitat, true, "Meat",8)
        {
            this.IsPreditor = IsPreditor;
        }

        public void Howl()     //Method for the Wolf to make a sound
        {
            Console.WriteLine($"Oooooh Aooooohhh");
        }

        public void Move()     //Method that tells how the wolf moves per day.
        {
            Console.WriteLine($"Wolves can move up to 5 miles per day");
          
        }

    

        

    }
}
