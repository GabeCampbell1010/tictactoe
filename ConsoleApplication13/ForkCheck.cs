using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{//this was the original fork checking method that is now no longer used in the main program
    class ForkCheck
    {
        public static bool fork(int[] arr)
        {
            if (WinCheck.Win(arr)) { return false; }
            int count = 0;
            foreach(int x in arr) { if(x != 0) { count++; } }
            if(count > 5) { return false; }
            if(ForkValid.ForkVal(arr) < 2) { return false; }
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 2)
                {
                    if (arr[i] == arr[(i + 1) % arr.Length] && arr[i] == arr[(i + 3) % arr.Length]) { return true; }
                    if (arr[i] == arr[(i + 1) % arr.Length] && arr[i] == arr[(i + 4) % arr.Length] && arr[0] != arr[5]) { return true; }
                    if (arr[i] == arr[(i + 3) % arr.Length] && arr[i] == arr[(i + 4) % arr.Length] && arr[2] != arr[3]) { return true; }
                    if (arr[i] == arr[(i + 2) % arr.Length] && arr[i] == arr[(i + 3) % arr.Length]) { return true; }
                    if (arr[i] == arr[(i + 4) % arr.Length] && arr[i] == arr[(i + 6) % arr.Length] && arr[1] != arr[7] && arr[0] != arr[7] && arr[1] != arr[6]) { return true; }
                    if (arr[i] == arr[(i + 2) % arr.Length] && arr[i] == arr[(i + 6) % arr.Length] && arr[1] != arr[3] && arr[2] != arr[7] && arr[1] != arr[8]) { return true; }
                }
            }
            if (arr[4] == 2)
            {
                if (arr[0] == arr[2] && arr[2] == arr[4]) { return true; }
                if (arr[6] == arr[8] && arr[8] == arr[4]) { return true; }
            }
            return false;
        }
    }
}
