using System;
using System.Collections.Generic;

//Write a program to check if in a given expression the brackets are put correctly.

namespace _02.Correct_brackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an expression: ");
            string expression = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool isCorrect = true;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    stack.Push(expression[i]);
                }
                if (expression[i] == ')')
                {
                    if (stack.Count != 0 && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        isCorrect = false;
                        break;
                    }
                }
            }

            if (isCorrect == true)
            {
                Console.WriteLine("The brackets are correct.");
            }
            else
            {
                Console.WriteLine("The brackets are incorrect.");
            }
        }
    }
}
