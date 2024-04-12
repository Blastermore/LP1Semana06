using System;

namespace ColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color c = new Color(240,0,7);
            Sphere s = new Sphere(c,15);

            s.Throw();
            s.Throw();
            Console.WriteLine(s.Radius);
            s.Pop();
            s.Throw();
            Console.WriteLine(s.Thrown);
            Console.WriteLine(s.Color);

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

            Console.WriteLine($"Sphere1 times thrown:{s1.Thrown}");
            Console.WriteLine($"Sphere2 times thrown:{s2.Thrown}");

            byte r = s1.Color.Red;
            byte g = s1.Color.Green;
            byte b = s1.Color.Blue;
            byte a = s1.Color.Alpha;
            
            Console.WriteLine($"Esfera 1: r:{r} g:{g} b:{b} alpha:{a}");
            Console.WriteLine($"grey:{s1.Color.Grey} ");

            r = s2.Color.Red;
            g = s2.Color.Green;
            b = s2.Color.Blue;
            a = s2.Color.Alpha;

            Console.WriteLine($"Esfera 2: r:{r} g:{g} b:{b} alpha:{a}");
            Console.WriteLine($"grey:{s2.Color.Grey} ");
        }
    }
}