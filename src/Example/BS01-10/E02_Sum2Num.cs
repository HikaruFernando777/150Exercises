using System;

namespace src
{
    public class E02_Sum2Num
    {
        public int _SUMA = 0;
        public void Sum(int numA, int numB)
        {
            int sum = 0;
            sum = numA + numB;
            _SUMA = numA + numB;
            Console.WriteLine(sum);
        } 

        public int SumInt(int numA, int numB)
        {
            int sum = 0;
            sum = numA + numB;
            sum = sum + _SUMA;
            return sum;
        }
    }
}