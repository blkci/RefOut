using System;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 100;
            int number2 = 200;
            Console.WriteLine(sum(number1,number2)); //Answer will be 210. Because we redefined number1 in sum method.
            Console.WriteLine(number1); //number1 is not change. Because number1 is not reference. It is just a variable of 100.

            Console.WriteLine(sum2(ref number1, number2));//But now we sent a reference number of number1 and we changed it in sum2. So number1's value will change.
            Console.WriteLine(number1); //we can see here. Now number1's value is 99.
        }

        static int sum(int num1,int num2)
        {
            num1 = 10;
            return num1 + num2;
        }

        static int sum2(ref int num1, int num2)
        {
            num1 = 99;
            return num1 + num2;
        }
    }
}
