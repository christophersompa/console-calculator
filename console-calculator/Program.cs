using System;

namespace console_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This Is My Calculator!");

            Console.WriteLine("Please Enter A Number:");

            string userPrompt = Console.ReadLine();

            int num1 = int.Parse(userPrompt);

            Console.WriteLine("Please Enter An Operator:");

            if (num1 is int)
            {
                string userPromptTwo = Console.ReadLine();

                if (userPromptTwo == "+")
                {
                    Console.WriteLine("Please Enter Another Number:");

                    string userPromptThree = Console.ReadLine();

                    int num2 = int.Parse(userPromptThree);

                    Console.Write("Sum: ");

                    Console.WriteLine(num1 + num2);
                }
                else if (userPromptTwo == "-")
                {
                    Console.WriteLine("Please Enter Another Number:");

                    string userPromptThree = Console.ReadLine();

                    int num2 = int.Parse(userPromptThree);

                    Console.Write("Sum: ");

                    Console.WriteLine(num1 - num2);
                }
                else if (userPromptTwo == "/")
                {
                    Console.WriteLine("Please Enter Another Number:");

                    string userPromptThree = Console.ReadLine();

                    int num2 = int.Parse(userPromptThree);

                    Console.Write("Sum: ");

                    Console.WriteLine(num1 / num2);
                }
                else if (userPromptTwo == "*")
                {
                    Console.WriteLine("Please Enter Another Number:");

                    string userPromptThree = Console.ReadLine();

                    int num2 = int.Parse(userPromptThree);

                    Console.Write("Sum: ");

                    Console.WriteLine("Sum:" + num1 * num2);
                }
                else
                {
                    Console.WriteLine("Incorrect Maths Operator!");
                }        
            }
            else
            {
                Console.WriteLine("Incorrect Input, Please Input A Number!");
            }

            Console.ReadLine();
        }
    }
}
