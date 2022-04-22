using System;

namespace Calc
{
    internal class Meths
    {
        private int _number;

        public Meths(int number)
        {
            _number = number;
        }

        public string NumberFact { get { return $"{Factorial(_number)}"; } }
        public string NumberSum { get { return $"{Sum(_number)}"; } }
        public string NumberMaxEven { get { return $"{MaxEven(_number)}"; } }

        private int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        private int Sum(int n)
        {
            int result = 0;
            for(int i = 1; i <= n; i++)
            {
                result += i;
            }
            return result;
        }

        private int MaxEven(int n)
        {
            int result = 0;
            for(var i = 1; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    result = i;
                }
            }
            return result;
        }
    }
}
