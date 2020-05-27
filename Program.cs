using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square() { Size = 50 }; var calc = new CalcAdapter();
            var area = calc.CalculateArea(square);
            Console.WriteLine($"ADAPTER PATTERN AREA of square {square.Size}: {area}");
            Console.ReadKey();
        }
    }
}
