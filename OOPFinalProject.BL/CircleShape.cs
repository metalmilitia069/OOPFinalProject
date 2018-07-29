using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFinalProject.BL
{
    [Serializable]
    public class CircleShape : ListofObjects
    {
        public CircleShape(int x, int y, int radius1, int radius2)
        {
            X = x;
            Y = y;
            Radius1 = radius1;
            Radius2 = radius2;
        }

        public CircleShape()
        {

        }

        private int _x;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        private int _y;

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        private int _radius1;

        public int Radius1
        {
            get { return _radius1; }
            set { _radius1 = value; }
        }

        private int _radius2;

        public int Radius2
        {
            get { return _radius2; }
            set { _radius2 = value; }
        }

        //public void ShowWidthAndHeight()
        //{
        //    Console.WriteLine("mozo" + this.Radius1.ToString());
        //}
    }
}
