using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOPFinalProject.BL
{
    [XmlInclude(typeof(RectangleShape))]
    [XmlInclude(typeof(CircleShape))]
    [Serializable]
    public abstract class ListofObjects : IListofObjects
    {

    }
}
