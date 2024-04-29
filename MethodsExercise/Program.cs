using System.Drawing;
using System.Xml.Linq;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string animal = "";
            string color = "";
            string band = "";

            Greeting();
            FillInTheColor();
            FillInTheAnimal();
            FillInTheBand();

            Console.WriteLine("Thanks for answerinmg my questions. Here's a little story we just made together,");
            Console.WriteLine($"Once upon a time in the enchanted substack, {name} the {animal} was checking his code for errors.");
            Console.WriteLine($"90% of their day was spent looking for errors. That made them feel {color}.");
            Console.WriteLine($"{name} decided to listen to some music to feel better. They played some {band} because that was their favoirite!");



            string str1 = MathSetUp1();
            string str2 = MathSetUp2(); 

            int num1 = int.Parse(str1);
            int num2 = int.Parse(str2);



            
            
           

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

            string HowManyTimes = "";
            HowManyTimesF();
           
        }


    //Exercise One Methods


        public static string Greeting()
        {
            Console.WriteLine("What's your name?");
            string  name = Console.ReadLine();
            Console.WriteLine($"Thanks {name}! Lets just go over a few more questions.");
            return name;
        }

        public static string FillInTheAnimal()
        {
            Console.WriteLine("Whats your favorite animal?");
            string animal = Console.ReadLine();
            return animal;
        }

        public static string FillInTheColor()
        {
            Console.WriteLine("Whats your favorite color?");
            string color = Console.ReadLine();
            return color;
        }

        public static string FillInTheBand()
        {
            Console.WriteLine("Whats your favorite band?");
            string band = Console.ReadLine();
            return band;
        }



        
     //Exercise Two Methods      
        


            

        public static string MathSetUp1()
        {
            Console.WriteLine("Now lets try some math functions!");
            Console.WriteLine("First I need you tyo choose two numbers");
            Console.WriteLine("Please enter your first number.");
            string str1 = Console.ReadLine();
            return str1;
            
        }

        public static string MathSetUp2()
        {
            Console.WriteLine("Please enter your second number.");
            string str2 = Console.ReadLine();
            return str2;
        }

    

//  Bonus Methods        

        public static void HowManyTimesF()
        {
            
            Console.WriteLine("***BONUS***BONUS***BONUS***");
            Console.WriteLine("pick a number");
            string HowManyTimes = Console.ReadLine();
           

            int HowManyInt = int.Parse(HowManyTimes);
            Console.WriteLine($"You picked {HowManyTimes}, so now you can pick that many numbers and we can see the total.");



            int i = 0;
            int sum1;
            int totalSum = 0;
            while (i < HowManyInt)
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
