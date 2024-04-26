namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
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
            
            string str1;
            string str2;

            int num1;
            int num2;


            Console.WriteLine("Now lets try some math functions!");
            Console.WriteLine("First I need you tyo choose two numbers");
            Console.WriteLine("Please enter your first number.");
            str1 = Console.ReadLine();
            Console.WriteLine("Please enter your second number.");
            str2 = Console.ReadLine();
            num1 = int.Parse(str1);
            num2 = int.Parse(str2);


            int solveSum = num1 + num2;
            int solveSub = num1 - num2;
            int solveMultiply = num1 * num2;
            int solveDivide = num1 / num2;
            int solveMod = num1 % num2;

            Console.WriteLine($"You chose {num1} and {num2}.");
            Console.WriteLine($"Addition: {num1} + {num2} equals {solveSum}.\n");
            Console.WriteLine($"Subtraction: {num1} - {num2} equals {solveSub}.\n");
            Console.WriteLine($"Multiplication: {num1} * {num2} equals {solveMultiply}.\n");
            Console.WriteLine($"Division: {num1} / {num2} equals {solveDivide}.\n");
            Console.WriteLine($"Modulus: {num1} % {num2} equals {solveMod}.\n");

            string howManyTimes;
            int i = 0;
            int sum1;
            int totalSum = 0;

            Console.WriteLine("***BONUS***BONUS***BONUS***");
            Console.WriteLine("pick a number");
            howManyTimes = Console.ReadLine();
            int howManyInt = int.Parse(howManyTimes);
            Console.WriteLine($"You picked {howManyTimes}, so now you can pick that many numbers and we can see the total.");

            while  (i < howManyInt)
            {
                Console.WriteLine("Pick a number\n");
    
                sum1 = int.Parse(Console.ReadLine());
                totalSum = totalSum + sum1;
                i++;
            }
            Console.WriteLine($"The total of the numbers that you entered is {totalSum}.");
        }


    }
}
