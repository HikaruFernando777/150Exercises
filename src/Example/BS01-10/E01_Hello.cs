using System;

namespace src
{
    public static class E01_Hello
    {
        /*
            Si un método (una función) está precedido por la palabra "static", 
            indica que es un "método de clase", es decir, un método que se podría 
            usar sin necesidad de declarar ningún objeto de la clase.
            
         */
        public static void firstE(){
            Console.WriteLine();
            Console.WriteLine("Ex1: ");
            Print();
        }
        public static void Print()
        {
            Console.Write("Hello");
            Console.Write("\nLau");
            Console.WriteLine();
            Console.WriteLine("Hello");
            Console.WriteLine("Lau");
        }
    }
}