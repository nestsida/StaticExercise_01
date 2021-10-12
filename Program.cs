using System;

namespace Static_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(32);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(0); 

            
            Console.WriteLine($"{celsius}");
            Console.WriteLine($" {fahrenheit}");
        }
    }
}
