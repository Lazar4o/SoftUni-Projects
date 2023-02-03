using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; set; }
        public int Height { get; set; }

        public void Draw()
        {
            for (int row = 0; row < Width; row++)
            {
                if (row == 0 || row + 1 == Width)
                {
                    for (int j = 0; j < Height; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    continue;
                }
                Console.Write("*");
                for (int j = 0; j < Height - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
        }
    }
}
