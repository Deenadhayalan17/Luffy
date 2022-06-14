using System;

namespace Luffy
{
    public class Calculator
    {
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
    }

  
}
