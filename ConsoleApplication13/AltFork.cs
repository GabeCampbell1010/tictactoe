using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class AltFork
    {//this is a new, better fork check that simply checks if two or more wins are possible for player 2 on the next turn
        public static bool check(int[] arr)
        {
            int count = 0;
            foreach (int x in arr) { if (x != 0) { count++; } }
            if (count != 5) { return false; }

            if (WinValid.WinVal(arr) >= 1) { return false; } 

            int coun = 0;
            
            for (int i = 0; i < 9; i++)
            {
                if(arr[i] == 0)
                {
                    arr[i] = 2;
                    if (WinCheck.Win(arr)) { coun++; }
                    arr[i] = 0;
                }
                
            }
            if (coun > 1) { return true; }
            return false;
            
        }
    }
}
