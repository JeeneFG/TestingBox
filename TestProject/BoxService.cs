using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject
{
    public  class BoxService
    {
        public double GetVolume(Box box)
        {
            if (box == null)
            {
                throw new ArgumentException("Ссылка не указывает на объект теперь");
            }     

            return box.Lenght * box.Width * box.Height;
        }

        public double GetSurfaceSquare(Box box)
        {
            if (box == null)
            {
                throw new ArgumentException("Ссылка не указывает на объект");
            }            

            return (box.Height * box.Lenght) * 2 + 
                (box.Height * box.Width) * 2 + 
                (box.Lenght * box.Width) * 2;
        }
    }
}
