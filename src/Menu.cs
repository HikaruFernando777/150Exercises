namespace src
{
    using System;
    public class Menu
    {
        public void menushift()
        {
            Console.WriteLine("Por favor elija el número del ejercicio que desea ejecutar.");
            var exNum = Convert.ToInt32(Console.ReadLine());
            switch (exNum){
                case 1:
                    E01_Hello.firstE();
                break;
                case 2:
                    E02_Sum2Num.SecondE();
                break;
                case 3:
                break;
                default:
                    Console.ReadKey();
                break;
            }
        }
    }
}