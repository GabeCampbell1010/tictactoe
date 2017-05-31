using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class PrintGame
    {//used to print out the board state in the form of a tic tac toe board rather than just a single 9 item line of integers
        public static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine(arr[i]);
                }
                else
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }

    }
}
