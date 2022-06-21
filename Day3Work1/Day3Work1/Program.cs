using System;
using System.Linq;

namespace Day3Work1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int  number1 = 20;
            //int number2 = 100;
            //var result = Add(out number1, number2);

            //Console.WriteLine(result);
            //Console.WriteLine(number1);


            Console.WriteLine(Multipy(2, 4));
            Console.WriteLine(Multipy(2, 4,5));

            Console.WriteLine(Add2(2, 3, 4, 5, 6, 7, 8, 9, 10, 45, 125, 65, 45));
            
           
        }

        static int Add(out int number1 , int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multipy(int number1,int number2)
        {
            return number1 * number2;
        }

        static int Multipy(int number1,int number2,int number3)
        {
            return number1 * number2 * number3;

        }

        static int Add2(params int[] numbers)
        {
            return numbers.Sum();
        }



    }
}
