using System;

using System.Collections.Generic;

namespace StakQueueFilesTask
{
    internal class Program
    {

        public static void StartSystem()
        
            
        {
            Console.WriteLine("Welcome to the String Reverser System!");
            Console.WriteLine("choice the number");
            Console.WriteLine("1. Enter a string to reverse:");
            Console.WriteLine("2. Evaluate Postfix Expression");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter a string to reverse:");
                    string input = Console.ReadLine();
                    string reversedString = ReverseString(input);
                    Console.ReadLine();

                    Console.WriteLine($"Reversed string: {reversedString}");
                    break;
               
                case 2:
                    Console.WriteLine("Enter a postfix expression:");
                    string postfixExpression = Console.ReadLine();
                    double result = EvaluatePostfix(postfixExpression);
                    Console.WriteLine($"Result: {result}");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        //Reverse a String Using Stack 

        public static string ReverseString(string str)
        {
            string reversedString="";
            Stack<char>  stack = new Stack<char>();

            foreach (char ch in str)
            {
                stack.Push(ch);
            }

            foreach (char ch2 in stack)
            {
                Console.Write(ch2);

            }


            int choice = int.Parse(Console.ReadLine());
           
            return reversedString;// complate funcation one

        }
        //Evaluate Postfix Expression Using Stack
        public static double EvaluatePostfix(string expression)
        {
            Stack<double> stack = new Stack<double>();
            foreach (char token in expression)
            {
                if (char.IsDigit(token))
                {
                    stack.Push(double.Parse(token.ToString()));
                }
                else
                {
                    double operand2 = stack.Pop();
                    double operand1 = stack.Pop();
                    double result = PerformOperation(operand1, operand2, token);
                    stack.Push(result);
                }
            }
            return stack.Pop();
        }




        static void Main(string[] args)
        {
            StartSystem();
           

            
        }









    }
}
