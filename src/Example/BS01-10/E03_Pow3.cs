using System;

namespace src
{
    public static class E03_Pow3
    {
        //Write a program in C# Sharp to display the cube of the number upto given an integer.
        public static void Loops()
        {
            var x = 0;
            Console.WriteLine("Indique hasta que número desea imperimir los cubos:");
            x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                var cube = Math.Pow(i, 3);

                Console.WriteLine("El número es " + i + " y su cubo es: " + cube);

            }
            
            Console.ReadKey();

        }

        public static void Loops2(){
            var x = 0;
            Console.WriteLine("Indique hasta que número desea imperimir los cubos:");
            x = Convert.ToInt32(Console.ReadLine());

            int n = 1;
            while (n <= x)
            {

                var cube = Math.Pow(n, 3);

                Console.WriteLine("El número es " + n + " y su cubo es: " + cube);

                if (n == 1)
                {
                    n = n + 2;
                }
                else
                {
                    n++;
                }

            }
            Console.ReadKey();
        }
    }
}