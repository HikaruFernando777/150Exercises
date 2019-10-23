using System;

namespace src
{
    public static class E02_Sum2Num
    {
        //_SUMA = variable pública de la clase para uso Global
        public static int _SUMA = 0;

        public static void SecondE()
        {
            var num1 = Convert.ToInt32(Console.ReadLine());
            var num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("E2: ");
            Console.WriteLine();
            Console.WriteLine("Void");
            Sum(num1, num2);

            Console.WriteLine();
            Console.WriteLine("Suma");
            var suma = SumInt(3, 4);
            Console.WriteLine(suma);
            Console.WriteLine();
            ArrayLoop();
        }

        public static void Sum(int numA, int numB)
        {
            var sum = 0;
            sum = numA + numB;
            _SUMA = numA + numB;
            Console.WriteLine(sum);
        }

        public static int SumInt(int numA, int numB)
        {
            var sum = 0;
            sum = numA + numB;
            sum = sum + _SUMA;
            return sum;
        }

        public static void ArrayLoop(){
            
            int[] intArray = new int[4];
            for (var i = 0; i < 4; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int y = 0;
            for (var j = 0; j < 4; j++)
            {
                Console.WriteLine(intArray[j]);
                if (j == 3)
                    Console.WriteLine(SumInt(intArray[y], intArray[y + 1]));
            }
        }
    }
}