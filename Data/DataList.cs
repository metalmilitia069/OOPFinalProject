using OOPFinalProject.BL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data1
{
    [Serializable]
    public class DataList //: IListofShapes
    {
        public List<RectangleShape> recList = new List<RectangleShape>();
        List<CircleShape> circList = new List<CircleShape>();
        DrawingShapes FromDrawingToDataList;
        List<IListofObjects> listofObjects = new List<IListofObjects>();
        

        public DataList(DrawingShapes drawing)
        {
            foreach(var item in drawing.GetListofRectangles)
            {
                listofObjects.Add(item);
                recList.Add(item);
            }
            foreach(var item in drawing.GetListofCircles)
            {
                listofObjects.Add(item);
                circList.Add(item);
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
            //foreach (People p in listofContacts.contacts)
            //{
            //    peoples.Add(p);
            //}


            //foreach (People p in list)
            //{
            //    peoples.Add(p);
            //}

            using (Stream filestreamofContacts1 = new FileStream(@".\ListofShapes.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer1 = new XmlSerializer(typeof(List<RectangleShape>));
                serializer1.Serialize(filestreamofContacts1, recList);
            }

            using (Stream filestreamofContacts1 = new FileStream(@".\ListofShapes.xml", FileMode.Append, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer1 = new XmlSerializer(typeof(List<CircleShape>));
                serializer1.Serialize(filestreamofContacts1, circList);
            }


        }

        public void DeserializeIt()
        {
            if (@".\ListofShapes.xml" != null)
            {
                XmlSerializer serializer2 = new XmlSerializer(typeof(List<RectangleShape>));
                using (FileStream filestreamofContacts = File.OpenRead(@".\ListofShapes.xml"))
                {
                    recList = (List<RectangleShape>)serializer2.Deserialize(filestreamofContacts);
                }

                //foreach (RectangleShape p in )
                //{
                //    listofContacts.AddToList(p);
                //}
            }

            //return recList;
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
