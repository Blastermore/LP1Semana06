using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        readonly private Color color;
        private int radius;
        private int thrown;
        public Sphere(Color color, int radius)
        {
            this.color = color;
            this.radius = radius;
            thrown = 0;
        }
        public void Pop()
        {
            radius = 0;
        }
        public void Throw()
        {
            if (radius > 0)
            {
                thrown += 1;
            }
        }
        public int GetTimesThrown()
        {
            return thrown;
        }

        public Color GetColor()
        {
            return color;
        }
    }
}