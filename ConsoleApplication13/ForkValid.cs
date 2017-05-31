using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class ForkValid
    {
        public static int ForkVal(int[] arr)
        {
            int count = 0;

            //top row
            if (arr[0] == 2 && arr[1] == 2 && arr[2] == 0) { count++; }
            if (arr[0] == 2 && arr[1] == 0 && arr[2] == 2) { count++; }
            if (arr[0] == 0 && arr[1] == 2 && arr[2] == 2) { count++; }

            //mid row
            if (arr[3] == 2 && arr[4] == 2 && arr[5] == 0) { count++; }
            if (arr[3] == 2 && arr[4] == 0 && arr[5] == 2) { count++; }
            if (arr[3] == 0 && arr[4] == 2 && arr[5] == 2) { count++; }

            //bottom row
            if (arr[6] == 2 && arr[7] == 2 && arr[8] == 0) { count++; }
            if (arr[6] == 2 && arr[7] == 0 && arr[8] == 2) { count++; }
            if (arr[6] == 0 && arr[7] == 2 && arr[8] == 2) { count++; }

            //left col
            if (arr[0] == 2 && arr[3] == 2 && arr[6] == 0) { count++; }
            if (arr[0] == 2 && arr[3] == 0 && arr[6] == 2) { count++; }
            if (arr[0] == 0 && arr[3] == 2 && arr[6] == 2) { count++; }

            //mid col
            if (arr[1] == 2 && arr[4] == 2 && arr[7] == 0) { count++; }
            if (arr[1] == 2 && arr[4] == 0 && arr[7] == 2) { count++; }
            if (arr[1] == 0 && arr[4] == 2 && arr[7] == 2) { count++; }

            //right col
            if (arr[2] == 2 && arr[5] == 2 && arr[8] == 0) { count++; }
            if (arr[2] == 2 && arr[5] == 0 && arr[8] == 2) { count++; }
            if (arr[2] == 0 && arr[5] == 2 && arr[8] == 2) { count++; }

            //left diag
            if (arr[0] == 2 && arr[4] == 2 && arr[8] == 0) { count++; }
            if (arr[0] == 2 && arr[4] == 0 && arr[8] == 2) { count++; }
            if (arr[0] == 0 && arr[4] == 2 && arr[8] == 2) { count++; }

            //right diag
            if (arr[2] == 2 && arr[4] == 2 && arr[6] == 0) { count++; }
            if (arr[2] == 2 && arr[4] == 0 && arr[6] == 2) { count++; }
            if (arr[2] == 0 && arr[4] == 2 && arr[6] == 2) { count++; }

            return count;
        }

        public static int ForkDuplicate(int[] arr1, int[] arr2)
        {
            int count = 0;
            for(int i = 0; i<9; i++)
            {
                if(arr1[i] == 2 && arr1[i] == arr2[i])
                {
                    count++;
                }
            }
            return count;
        }

    }
}
