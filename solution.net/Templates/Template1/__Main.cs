using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Template1
{   
    public class __Main
    {
        //--------------------------------------------------------------------------------------------------------------------------------
        // Main
        //--------------------------------------------------------------------------------------------------------------------------------

        static void Main(string[] args)
        {
            using(StreamReader inputDataFile = new StreamReader(@"partition:\path"))
            {
                int n = Convert.ToInt32(inputDataFile.ReadLine());
                int[] arr = Array.ConvertAll(inputDataFile.ReadLine().Split(' '), p => Convert.ToInt32(p));
            }
        }  
    }
}
