using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Connected
    {
        

        public static bool connect(int[] arr1, int[] arr2)
        {//checks if there is only one cell different between arrays, and if one of them has one more entry than the other, if so they are connected
            //used for making the graph of the game
            int count = 0;
            int num1 = 0;
            int num2 = 0;
            for (int i = 0; i < 9; i++)
            {
                if (arr1[i] != arr2[i]){count++;}
                if (arr1[i] != 0) { num1++; }
                if (arr2[i] != 0) { num2++; }
            }
            if (count == 1 && Math.Abs(num1-num2) == 1)
            {
                return true;
            }
            return false;
        }
    }
}
