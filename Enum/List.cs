using System;
using System.Collections.Generic;
using System.Text;

namespace Enum
{
    class List
    {
        enum Color
        {
            Red,
            Green,
            Blue
        }
        static void PrintColor(Color color)
        {
            switch (color)
            {
                case Color.Red:
                    Console.WriteLine("Red");
                    break;
                case Color.Green:
                    Console.WriteLine("Green");
                    break;
                case Color.Blue:
                    Console.WriteLine("Blue");
                    break;
            }
        }
        static void Main()
        {
            Color c = Color.Red;
            PrintColor(c);
            PrintColor(Color.Blue);
        }
    }
}
