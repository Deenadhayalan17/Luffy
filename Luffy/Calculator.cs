using System;
using System.Collections.Generic;

namespace Luffy
{
    public class Calculator
    {
        private List<int> OddList = new();
        public int AddNumber(int a , int b )
        {
            return a + b;
        }
        public bool IsOddNumber(int a)
        {
            return a %2 != 0;
            //if (a % 2 == 0)
            //{ 
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
        public double AddNumberdouble(double a, double b)
        {
            return a + b;
        }

        public List<int> OddListInRange(int min , int max)
        {
            OddList.Clear();
            for (int i = min; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    OddList.Add(i);
                }
            }
            return OddList;
        }

    }

  
}
