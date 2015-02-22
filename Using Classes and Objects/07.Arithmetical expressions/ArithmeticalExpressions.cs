using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;
using System.Linq;

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
            //Removing all whitespaces from the equation, making it lowetcase and splitting
            expression = Regex.Replace(expression, @"\s+", string.Empty);
            expression.ToLower();
            string[] tokens = Regex.Split(expression, @"([\+\-\*\(\)\/\,])");
            tokens = tokens.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            //Shunting-yard algorithm
            Queue<string> queue = new Queue<string>();
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < tokens.Length; i++)
            {
                //Checking if the token is a number, then adding it to the output queue.
                try
                {
                    double.Parse(tokens[i], CultureInfo.InvariantCulture);
                    queue.Enqueue(tokens[i]);
                    continue;
                }
                catch (Exception e)
                {
                }

                //Check if the token is a function token or '(' , then pushing it onto the stack.
                if ("ln".Equals(tokens[i])
                        || "sqrt".Equals(tokens[i])
                        || "pow".Equals(tokens[i])
                        || "(".Equals(tokens[i]))
                {
                    stack.Push(tokens[i]);
                    continue;
                }

                //Check if the token is a function argument separator (comma), then pop operators off the stack
                //onto the output queue, until the token at the top of the stack is a left parenthesis
                if (",".Equals(tokens[i]))
                {
                    while ("(".Equals(stack.Peek()) != true)
                    {
                        queue.Enqueue((String)stack.Pop());
                    }
                    continue;
                }

                //Checking if the token is an operator
                //If the stack is empty -> (2)
                //If the token is (+;-) and at there is an operator at the top of the stack 
                //or the token is (*;/) and there is (*;/) at the top of the stack,
                // pop the operator from the top of the stack to the queue then -> (2)
                //(2)Push token to stack
                if ("+".Equals(tokens[i]) || "-".Equals(tokens[i]) || "*".Equals(tokens[i]) || "/".Equals(tokens[i]))
                {
                    if (("-".Equals(tokens[i]) && (i == 0))
                            || ("-".Equals(tokens[i]) && ",".Equals(tokens[i - 1]))
                            || ("-".Equals(tokens[i]) && "(".Equals(tokens[i - 1])))
                    {
                        try
                        {
                            double.Parse(tokens[i + 1], CultureInfo.InvariantCulture);
                            tokens[i + 1] = "-" + tokens[i + 1];
                            continue;
                        }
                        catch (Exception e)
                        {
                        }
                    }
                    else if (stack.Count == 0)
                    {
                    }
                    else if (("+".Equals(tokens[i]) || "-".Equals(tokens[i])) && ("+".Equals(stack.Peek()) || "-".Equals(stack.Peek())
                          || "*".Equals(stack.Peek()) || "/".Equals(stack.Peek())))
                    {
                        queue.Enqueue((String)stack.Pop());
                    }
                    else if (("*".Equals(tokens[i]) || "/".Equals(tokens[i])) && ("*".Equals(stack.Peek()) || "/".Equals(stack.Peek())))
                    {
                        queue.Enqueue((String)stack.Pop());
                    }
                    stack.Push(tokens[i]);
                    continue;
                }

                //Checking if the token is ')':
                //Until the token at the top of the stack is '(', pop operators off the stack onto the output queue.
                //Pop the '(' from the stack, but not onto the output queue.
                //If the token at the top of the stack is a function token, pop it onto the output queue.
                if (")".Equals(tokens[i]))
                {
                    while ("(".Equals(stack.Peek()) != true)
                    {
                        queue.Enqueue((String)stack.Pop());
                    }
                    stack.Pop();
                    while ((stack.Count != 0) && ("ln".Equals(stack.Peek())
                                                    || "sqrt".Equals(stack.Peek())
                                                    || "pow".Equals(stack.Peek())))
                    {
                        queue.Enqueue((String)stack.Pop());
                    }
                }
            }

            //If there are still operators in the stack - push to them to the queue
            int n = stack.Count;
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue((String)stack.Pop());
            }

            //calling reversePolish method with the queue 
             postfix(queue);
        }

        static void postfix(Queue<String> expression)
        {
            Stack<double> stack = new Stack<double>();
            double a;
            double b;

            foreach (var s in expression)
            {
                switch (s)
                {
                    case "sqrt":
                        a = (double)stack.Pop();
                        stack.Push(Math.Sqrt(a));
                        break;
                    case "+":
                        a = (double)stack.Pop();
                        b = (double)stack.Pop();
                        stack.Push(b + a);
                        break;
                    case "-":
                        a = (double)stack.Pop();
                        b = (double)stack.Pop();
                        stack.Push(b - a);
                        break;
                    case "*":
                        a = (double)stack.Pop();
                        b = (double)stack.Pop();
                        stack.Push(b * a);
                        break;
                    case "/":
                        a = (double)stack.Pop();
                        b = (double)stack.Pop();
                        stack.Push(b / a);
                        break;
                    case "pow":
                        a = (double)stack.Pop();
                        b = (double)stack.Pop();
                        stack.Push(Math.Pow(b, a));
                        break;
                    case "ln":
                        a = (double)stack.Pop();
                        stack.Push(Math.Log(a));
                        break;
                    default:
                        try
                        {
                            a = Double.Parse(s, CultureInfo.InvariantCulture);
                            stack.Push(a);
                        }
                        catch (Exception e)
                        {
                        }
                        break;
                }
            }
            Console.WriteLine(stack.Peek());
        }
        static void Main(string[] args)
        {
            ShuntingYard("(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)");
            ShuntingYard("pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)");
        }
    }
}
