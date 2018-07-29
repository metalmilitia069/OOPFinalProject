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
    public class DataList
    {
        public List<ListofObjects> listOfObjects = new List<ListofObjects>();
        

        public DataList(DrawingShapes drawing)
        {
            foreach(var item in drawing.GetListofRectangles)
            {   
                listOfObjects.Add(item);
            }
            foreach(var item in drawing.GetListofCircles)
            {
                listOfObjects.Add(item);
            }
        }

        public void SerializeIt()
        {   
            using (Stream filestreamofContacts1 = new FileStream(@".\ListofShapes.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer1 = new XmlSerializer(typeof(List<ListofObjects>));
                serializer1.Serialize(filestreamofContacts1, listOfObjects);
            }
        }

        public void DeserializeIt()
        {
            if (@".\ListofShapes.xml" != null)
            {
                XmlSerializer serializer2 = new XmlSerializer(typeof(List<ListofObjects>));
                using (FileStream filestreamofContacts = File.OpenRead(@".\ListofShapes.xml"))
                {   
                    listOfObjects = (List<ListofObjects>)serializer2.Deserialize(filestreamofContacts);
                }
            }
        }
    }
}
