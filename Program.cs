using System;
using Figgle;

namespace Banner
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length >= 1)
            {
                var text = string.Empty;
                foreach (var arg in args)
                {
                    text += $" {arg}";
                }
                Console.WriteLine(FiggleFonts.Standard.Render(text));
                return 0;
            }
            else
            {
                Console.WriteLine("Error : Text option missing. Hello <text>");
                return -1;
            }
        }
    }
}
