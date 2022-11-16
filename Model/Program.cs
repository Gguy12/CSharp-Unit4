using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Model
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTreeUtilities util = new BinaryTreeUtilities();
            Queue<int> Q = new Queue<int>();
            Q.Enqueue(1);
            Console.WriteLine(Q.First());
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
