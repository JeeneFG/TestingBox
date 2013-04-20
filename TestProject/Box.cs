using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject
{
    public class Box
    {

        public Box(double lenght, double width, double height)
        {
            Lenght = lenght;
            Width = width;
            Height = height;
        }

        //Длина в метра
        public double Lenght { get; set; }
        //Ширина в метрах
        public double Width { get; set; }
        //Высота в метрах
        public double Height { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Lenght, Width, Height);
        }
    }
}
