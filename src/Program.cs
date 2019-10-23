using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("E1: ");
            E01_Hello e01 = new E01_Hello();
            e01.Print();
            int num1, num2;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("E2: ");
            E02_Sum2Num e02 = new E02_Sum2Num();
            Console.WriteLine();
            Console.WriteLine("Void");
            e02.Sum(num1, num2);

            Console.WriteLine();
            Console.WriteLine("Suma");
            int suma = e02.SumInt(3, 4);
            Console.WriteLine(suma);

            int[] intArray = new int[4];
            for (var i = 0; i < 4; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int y=0;
            for (var j = 0; j < 4; j++)
            {
                
                Console.WriteLine(intArray[j]);
                if(j==3)
                    Console.WriteLine(e02.SumInt(intArray[y],intArray[y+1]));
            }

            Console.ReadKey();
        }
    }
}
