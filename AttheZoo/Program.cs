namespace AttheZoo
{
    internal class Program

        //In the main program we create the animals and make them do their methods. 
    {
        static void Main(string[] args)
        {
            Wolf wolf = new Wolf("Wolf", 10, "Wolf", "Forest", true);
            wolf.Animalinfo();
            wolf.Eat();
            wolf.Sleep();
            wolf.Move();
            wolf.MakeSound();
            wolf.Howl();
            
           
            Console.WriteLine();    //creates a space
            Console.WriteLine();

            Tiger tiger = new Tiger("Tiger", 2, "Tiger", "Tropical Rainforest", true);
            tiger.Animalinfo();
            tiger.Eat();
            tiger.Sleep();
            tiger.MakeSound();
            tiger.Roar();

            Console.WriteLine();  //creates a space 

            Snake rattlesnake = new Snake("Rattlesnake", 4, "Snake", "Deserted Areas", false);
            rattlesnake.Animalinfo();
            rattlesnake.Eat();
            rattlesnake.Sleep();
            rattlesnake.Venomous();
            rattlesnake.MakeSound();
            rattlesnake.Rattle();
          

            Console.WriteLine();  //creates a space

            Snake anaconda = new Snake("Anaconda", 13, "Snake", "Djungle", false);
            anaconda.Animalinfo();
            anaconda.Eat();
            anaconda.Sleep();
            anaconda.Hugs();
            anaconda.MakeSound();
            anaconda.NoSound();
           

        }
    }
}