using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Linq;
using System.IO;
using NUnit.Framework;

namespace Practice
{
    [TestFixture]
    public partial class Template2
    {
        [TestCase()]
        public void Main()
        {
            using(System.IO.StreamReader inputDataFile = new System.IO.StreamReader(@"partition:\path"))
            {
                int n = Convert.ToInt32(inputDataFile.ReadLine());
                int[] arr = Array.ConvertAll(inputDataFile.ReadLine().Split(' '), p => Convert.ToInt32(p));
            }
           
        }
    }
}
