using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOPFinalProject.BL
{
    [XmlInclude(typeof(RectangleShape))]
    [XmlInclude(typeof(CircleShape))]
    [Serializable]
    public class DrawingShapes
    {
        private List<RectangleShape> listofRec = new List<RectangleShape>();
        private List<CircleShape> listofCirc = new List<CircleShape>();
        Graphics g;
        IListofObjects ObjectToDraw;

        public DrawingShapes()
        {
            
        }

        public void AddToList(IListofObjects objects)
        {
            if (objects is RectangleShape rec)
            {
                listofRec.Add(rec);
            }
            if (objects is CircleShape circ)
            {
                listofCirc.Add(circ);
            }
            ObjectToDraw = objects;
        }

        public void DrawShape()
        {
            if (ObjectToDraw is RectangleShape rec)
            {
                g.DrawRectangle(Pens.Black, rec.X, rec.Y, rec.Width, rec.Height);
                g.FillRectangle(Brushes.Violet, rec.X, rec.Y, rec.Width, rec.Height);
                //listofRec.Add(rec);
            }
            if (ObjectToDraw is CircleShape circ)
            {
                g.DrawEllipse(Pens.Black, circ.X, circ.Y, circ.Radius1, circ.Radius2);
                g.FillEllipse(Brushes.Blue, circ.X, circ.Y, circ.Radius1, circ.Radius2);
                
                //listofCirc.Add(circ);
            }
        }

        public List<RectangleShape> GetListofRectangles
        {
            get { return listofRec; }
            set { listofRec = value; }
        }

        public List<CircleShape> GetListofCircles
        {
            get { return listofCirc; }
            set { listofCirc = value; }
        }

       



    }
}
