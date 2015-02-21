using System;
using System.Text.RegularExpressions;

//Write a program that calculates the value of given arithmetical expression.
//The expression can contain the following elements only:
//Real numbers, e.g. 5, 18.33, 3.14159, 12.6
//Arithmetic operators: +, -, *, / (standard priorities)
//Mathematical functions: ln(x), sqrt(x), pow(x,y)
//Brackets (for changing the default priorities): (, )

namespace _07.Arithmetical_expressions
{
    class ArithmeticalExpressions
    {
        static void ShuntingYard(String expression)
        {
            expression = Regex.Replace(expression, @"\s+", string.Empty);
            expression.ToLower();
            string[] tokens = Regex.Split(expression, @"([()+*/-])");
 
        }
        static void Main(string[] args)
        {
            ShuntingYard("(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)");
        }
    }
}
