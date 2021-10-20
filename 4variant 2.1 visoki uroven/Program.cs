using System;

namespace _4variant_2._1_visoki_uroven
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                Console.WriteLine("Введите х");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите y");
                double y = double.Parse(Console.ReadLine());
                if (x >= 0 && x <= 1 && y <= 1 && y >= -1) Console.WriteLine("Истина");
                else Console.WriteLine("Ложно");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
