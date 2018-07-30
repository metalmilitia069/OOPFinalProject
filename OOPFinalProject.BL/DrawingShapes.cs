using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        //Graphics g;
        //PaintEventArgs g;

        ListofObjects ObjectToDraw;

        public DrawingShapes()
        {
            
        }

        public void AddToList(ListofObjects objects)
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

        public void DrawShape(PaintEventArgs g)
        {
            if (ObjectToDraw is RectangleShape rec)
            {
                //g.Graphics.FillRectangle(new SolidBrush(Color.RoyalBlue), rec.X, rec.Y, rec.Width, rec.Height);
                //g.Graphics.FillRectangle(new SolidBrush(Color.RoyalBlue), mousePivot);
                g.Graphics.FillRectangle(Brushes.Violet, rec.X, rec.Y, rec.Width, rec.Height);
                g.Graphics.DrawRectangle(Pens.Black, rec.X, rec.Y, rec.Width, rec.Height);
                
            }
            if (ObjectToDraw is CircleShape circ)
            {
                g.Graphics.DrawEllipse(Pens.Black, circ.X, circ.Y, circ.Radius1, circ.Radius2);
                g.Graphics.FillEllipse(Brushes.Blue, circ.X, circ.Y, circ.Radius1, circ.Radius2);
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
