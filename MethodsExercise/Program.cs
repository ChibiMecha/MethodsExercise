namespace MethodsExercise
{
    public class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?\n Enter Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine($"\nGood Morning, {firstName}. Nice day to go hoop right?\n");
            Console.WriteLine($"Dude no. The sky is about to drop\n Enter Color:");
            string color = Console.ReadLine();
            Console.WriteLine($"\n{color}!!!!\n");
            Console.WriteLine("What?\n");
            Console.WriteLine($"Thats what color you should have picked for your Mustang. {color} is the bestest and most coolest color out.\n Yes because you got the worst color possible.\n");
            Console.WriteLine("No way you're still mad about the SmokeShow Grey paint job\n Enter wild animal name:");
            string animal = Console.ReadLine();
            Console.WriteLine($"Dude, You are as crazy as a {animal}\n Enter crazy rock band name:");
            string band = Console.ReadLine();
            Console.WriteLine($"That may be true but im not as mad as you after i tell you about the {band} concert");
        }   
    }
}
