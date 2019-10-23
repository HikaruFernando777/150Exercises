using System;

namespace src
{
    public static class E02_Sum2Num
    {
        //_SUMA = variable pública de la clase para uso Global
        public static int _SUMA = 0;

        public static void SecondE()
        {
            Console.WriteLine();
            Console.WriteLine("Ex2: ");
            Console.WriteLine("Digite dos números para las operaciones.");
            Console.WriteLine("Primero:");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo:");
            var num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Ejecutando método Sum:");
            Sum(num1, num2);

            Console.WriteLine();
            Console.WriteLine("Ejecutando método SumInt");
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
            Console.WriteLine("Asignando valor a la variable global _SUMA: " + _SUMA);
            Console.WriteLine(sum);
        }

        public static int SumInt(int numA, int numB)
        {
            var sum = 0;
            sum = numA + numB;
            sum = sum + _SUMA;
            return sum;
        }

        public static void ArrayLoop()
        {
            Console.WriteLine("Indique el tamaño del array que desea crear: ");
            var size = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[size];
            Console.WriteLine("Ingrese el valor de cada posición: ");
            var p = 0;
            for (var i = 0; i < size; i++)
            {
                p = i + 1;
                Console.WriteLine("Posición del arreglo número " + p);
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Arreglo impreso:");
            int y = 0;
            for (var j = 0; j < size; j++)
            {
                Console.WriteLine(intArray[j]);
                if (j == 3)
                {
                    Console.WriteLine("Suma de la posición 0 del arreglo, posición 1 y el valor de _SUMA = "+ _SUMA);
                    Console.WriteLine(SumInt(intArray[y], intArray[y + 1]));
                }
            }
        }
    }
}