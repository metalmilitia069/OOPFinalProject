using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPFinalProject.BL
{
    [Serializable]
    public class RectangleShape : ListofObjects
    {   
        public RectangleShape(int x, int y, int width, int height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }

        public RectangleShape()
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

        private int _width;

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        private int _height;

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        //public void ShowWidthAndHeight()
        //{
        //    Console.WriteLine("mozo" + this.Width + this.Height);
        //}
    }
}
