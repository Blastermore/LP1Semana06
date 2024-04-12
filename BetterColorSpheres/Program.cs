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
        }
    }
}