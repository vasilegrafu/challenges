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
    public partial class ProblemTemplate
    {
        [TestCase()]
        public void Main()
        {
            using(System.IO.StreamReader file = new System.IO.StreamReader(@"partition:\path"))
            {
                int n = Convert.ToInt32(file.ReadLine());
                int[] arr = Array.ConvertAll(file.ReadLine().Split(' '), p => Convert.ToInt32(p));
            }
           
        }
    }
}
