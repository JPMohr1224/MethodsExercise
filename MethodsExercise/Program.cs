namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string WriteAStory()
            {
                Console.WriteLine("What's your name?");
                string name = Console.ReadLine();
                Console.WriteLine($"Thanks {name}! Lets just go over a few more questions.");
                Console.WriteLine("Whats your favorite color?");
                string color = Console.ReadLine();
                Console.WriteLine("Whats your favorite animal?");
                string animal = Console.ReadLine();
                Console.WriteLine("Whats your favorite band?");
                string band = Console.ReadLine();
                Console.WriteLine("Thanks for answerinmg my questions. Here's a little story we just made together,");
                Console.WriteLine($"Once upon a time in the enchanted substack, {name} the {animal} was checking his code for errors.");
                Console.WriteLine($"90% of their day was spent looking for errors. That made them feel {color}.");
                Console.WriteLine($"{name} decided to listen to some music to feel better. They played some {band} because that was their favoirite!");
            }
 ;       }

       
    }
}
