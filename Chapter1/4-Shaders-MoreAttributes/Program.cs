﻿namespace LearnOpenTK
{
    class Program
    {
        private static void Main()
        {
            using (var window = new Window(800, 600, "LearnOpenTK - Shaders More Attributes !"))
            {
                window.Run(60.0);
            }
        }
    }
}
