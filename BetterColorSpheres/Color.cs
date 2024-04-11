using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        } 
        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }

        public byte Red {get;}
        public byte Green {get;}
        public byte Blue {get;}
        public byte Alpha {get;}


        public byte GetGrey()
        {
            int redInt = Convert.ToInt32(red);
            int greenInt = Convert.ToInt32(green);
            int blueInt = Convert.ToInt32(blue);
            byte grey = Convert.ToByte((redInt + greenInt + blueInt)/3);

            return grey;
        }
    }
}