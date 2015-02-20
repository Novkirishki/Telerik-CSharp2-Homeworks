using System;

//Write a program to convert from any numeral system of given
//base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

namespace _07.One_system_to_any_other
{
    class OneSystemToAnyOther
    {
        static void Convert(string number, int base1, int base2)
        {
            number.ToLower();

            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);
            number =  new string(charArray);

            long dec = 0;
            string result = "";
            //Turning the number in decimal
            for (int i = 0; i < number.Length; i++)
            {
                switch (number[i])
                {
                    case '1':
                        dec += 1 * (long)Math.Pow(base1, i);
                        break;
                    case '2':
                        dec += 2 * (long)Math.Pow(base1, i);
                        break;
                    case '3':
                        dec += 3 * (long)Math.Pow(base1, i);
                        break;
                    case '4':
                        dec += 4 * (long)Math.Pow(base1, i);
                        break;
                    case '5':
                        dec += 5 * (long)Math.Pow(base1, i);
                        break;
                    case '6':
                        dec += 6 * (long)Math.Pow(base1, i);
                        break;
                    case '7':
                        dec += 7 * (long)Math.Pow(base1, i);
                        break;
                    case '8':
                        dec += 8 * (long)Math.Pow(base1, i);
                        break;
                    case '9':
                        dec += 9 * (long)Math.Pow(base1, i);
                        break;
                    case 'a':
                        dec += 10 * (long)Math.Pow(base1, i);
                        break;
                    case 'b':
                        dec += 11 * (long)Math.Pow(base1, i);
                        break;
                    case 'c':
                        dec += 12 * (long)Math.Pow(base1, i);
                        break;
                    case 'd':
                        dec += 13 * (long)Math.Pow(base1, i);
                        break;
                    case 'e':
                        dec += 14 * (long)Math.Pow(base1, i);
                        break;
                    case 'f':
                        dec += 15 * (long)Math.Pow(base1, i);
                        break;
                    default:
                        break;
                }
            }

            //From decimal to base2
            while (dec > 0)
            {
                switch (dec % base2)
                {
                    case 1:
                        result += "1";
                        dec /= base2;
                        break;
                    case 2:
                        result += "2";
                        dec /= base2;
                        break;
                    case 3:
                        result += "3";
                        dec /= base2;
                        break;
                    case 4:
                        result += "4";
                        dec /= base2;
                        break;
                    case 5:
                        result += "5";
                        dec /= base2;
                        break;
                    case 6:
                        result += "6";
                        dec /= base2;
                        break;
                    case 7:
                        result += "7";
                        dec /= base2;
                        break;
                    case 8:
                        result += "8";
                        dec /= base2;
                        break;
                    case 9:
                        result += "9";
                        dec /= base2;
                        break;
                    case 10:
                        result += "a";
                        dec /= base2;
                        break;
                    case 11:
                        result += "b";
                        dec /= base2;
                        break;
                    case 12:
                        result += "c";
                        dec /= base2;
                        break;
                    case 13:
                        result += "d";
                        dec /= base2;
                        break;
                    case 14:
                        result += "e";
                        dec /= base2;
                        break;
                    case 15:
                        result += "f";
                        dec /= base2;
                        break;
                    default:
                        break;
                }
            }

            char[] charArray1 = result.ToCharArray();
            Array.Reverse(charArray1);
            result = new string(charArray1);

            Console.WriteLine("The number in numerical system with base {0} is {1}", base2, result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input the base of the numerical system of the first number: ");
            int base1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the number itself: ");
            string number = Console.ReadLine();

            Console.WriteLine("Input the base of the numerical system of the second number: ");
            int base2 = int.Parse(Console.ReadLine());

            Convert(number, base1, base2);
        }
    }
}
