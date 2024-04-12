using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        public Color Color {get;}
        public int Radius {get;private set;}
        public int Thrown{get; private set;}
        public Sphere(Color color, int radius)
        {
            Color = color;
            Radius = radius;
            Thrown = 0;
        }

        public void Throw()
        {
            if (Radius > 0)
            {
                Thrown += 1;
            }
        }
    }
}