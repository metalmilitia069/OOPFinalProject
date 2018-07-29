using OOPFinalProject.BL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data1
{
    [Serializable]
    public class DataList //: IListofShapes
    {
        List<RectangleShape> recList;
        List<CircleShape> circList;
        DrawingShapes FromDrawingToDataList;
        List<IListofObjects> listofObjects = new List<IListofObjects>();
        

        public DataList(DrawingShapes drawing)
        {
            foreach(var item in drawing.GetListofRectangles)
            {
                listofObjects.Add(item);
            }
            foreach(var item in drawing.GetListofCircles)
            {
                listofObjects.Add(item);
            }
            //foreach(var item in list)
            //{
            //    if(item is RectangleShape rec)
            //    {
            //        recList.Add(rec);
            //    }
            //    if(item is CircleShape circ)
            //    {
            //        circList.Add(circ);
            //    }

            //}
        }

        public void SerializeIt()
        {
            
        }
        //}
        //List<IListofShapes> listofShapes = new List<IListofShapes>();
        //IListofShapes dd;
        //public DataList(Rectangle obj)
        //{
        //    dd = (IListofShapes)obj;
        //    listofShapes.Add(dd);
        //}
    }
}
