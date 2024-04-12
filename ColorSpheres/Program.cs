using System;
using System.Runtime.Intrinsics.Arm;

namespace ColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color1 = new Color(240,0,7);
            Color color2 = new Color(100,20,80);

            Sphere s1 = new Sphere(color1,20);
            Sphere s2 = new Sphere(color2, 15 );

            s1.Throw();
            s2.Throw();
            s1.Throw();
            s2.Throw();

            s1.Pop();
            s2.Pop();

            s1.Throw();
            s2.Throw();

            Console.WriteLine($"Sphere1 times thrown:{s1.GetTimesThrown()}");
            Console.WriteLine($"Sphere2 times thrown:{s2.GetTimesThrown()}");

            byte r = s1.GetColor().GetRed();
            byte g = s1.GetColor().GetGreen();
            byte b = s1.GetColor().GetBlue();
            byte a = s1.GetColor().GetAlpha();
            
            Console.WriteLine($"Esfera 1: r:{r} g:{g} b:{b} alpha:{a}");
            Console.WriteLine($"grey:{s1.GetColor().GetGrey()} ");

            r = s2.GetColor().GetRed();
            g = s2.GetColor().GetGreen();
            b = s2.GetColor().GetBlue();
            a = s2.GetColor().GetAlpha();

            Console.WriteLine($"Esfera 2: r:{r} g:{g} b:{b} alpha:{a}");
            Console.WriteLine($"grey:{s2.GetColor().GetGrey()} ");
            
        }
    }
}
