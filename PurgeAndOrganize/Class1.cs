using System;
using System.Collections.Generic;
using System.Linq;

namespace PurgeAndOrganize
{
    public class Class1
    {
        //Given an array of numbers, write a function that returns an array that...
        //Has all duplicate elements removed.
        //Is sorted from least value to greatest value.

        public static double[] UniqueSort(double[] arr)
        {
            return arr.Distinct().OrderBy(a => a).ToArray();
        }
    }
}
