using Data1;
using OOPFinalProject.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            RectangleShape rect = new RectangleShape(0, 0, 100, 100);
            RectangleShape rect1 = new RectangleShape(0, 0, 50, 50);
            RectangleShape rect2 = new RectangleShape(0, 0, 25, 25);
            Console.WriteLine($"rectangle created: {rect}");

            

            CircleShape circ = new OOPFinalProject.BL.CircleShape(0, 0, 80, 80);

            
            DrawingShapes drawingShapes1 = new DrawingShapes();

            

            drawingShapes1.AddToList(rect1);
            rect1 = new RectangleShape(10, 10, 666, 999);
            
            drawingShapes1.AddToList(rect1);

            drawingShapes1.AddToList(circ);
            circ = new CircleShape(333, 333, 1000, 1000);
            drawingShapes1.AddToList(circ);

            foreach (var rec in drawingShapes1.GetListofRectangles)
            {
                Console.WriteLine("Rectangle: " + rec.Height.ToString());
                
            }

            foreach (var rec in drawingShapes1.GetListofCircles)
            {
                Console.WriteLine("Circle: " + rec.Radius1.ToString());

            }
             



            Console.WriteLine("Number of Entities in DrawingShapes List of Rectangles =" + drawingShapes1.GetListofRectangles.Count);
            Console.WriteLine("Number of Entities in DrawingShapes List of Circles =" + drawingShapes1.GetListofCircles.Count);


            DataList dataList = new DataList(drawingShapes1);


            dataList.SerializeIt();

            dataList.listOfObjects = null;

            Console.WriteLine("lalalala");



            //Console.WriteLine("Antes do Deserialize >>> " + dataList.listOfObjects.ElementAt(0));

            dataList.DeserializeIt();

            foreach(var item in dataList.listOfObjects)
            {
                if(item is RectangleShape rec)
                {
                    Console.WriteLine($"This Rectangle Shape has Width =  {rec.Width}");
                }
                if(item is CircleShape cU)
                {
                    Console.WriteLine($"This Circle Shape has Radius =  {cU.Radius1}");
                }
            }

            rect2 = new RectangleShape(0, 0, 2222, 2222);

            drawingShapes1.AddToList(rect2);
            dataList = new DataList(drawingShapes1);

            dataList.SerializeIt();




            //Console.WriteLine("Depois do Deserialize >>> " + dataList.listOfObjects.ElementAt(0)); 

            //Console.WriteLine($"The Rectangle info is: {rect2.X}, {rect2.Y}, {rect2.Width}, {rect2.Height}");

            Console.ReadLine();
        }
    }
}
