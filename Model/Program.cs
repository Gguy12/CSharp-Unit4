using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Model
{
    //shinoy
    internal class Program
    {
        static void Main(string[] args)
            //Deez Nuts
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            StackUtils SU = new StackUtils();
            SU.pr(stack);
            Console.ReadLine();
        }
        //a static function the gets length and max value and makes a random array
        public static int[] RandomArray(int length, int maxValue)
        {
            Random random = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(maxValue);
            }
            return array;
        }
    }
}
