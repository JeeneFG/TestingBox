using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject
{
    public class Store
    {
        public List<Box> _boxes = new List<Box>();

        public List<Box> Boxes
        {
            get { return _boxes; }
            set { _boxes = value; }
        }

        public void Add(Box box)
        {
            _boxes.Add(box);
        }
    }
}
