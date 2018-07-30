using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data1;
using OOPFinalProject.BL;

namespace OOPFinalProject
{
    public partial class Form1 : Form
    {
        RectangleShape rect;
        CircleShape circ;
        DrawingShapes drawingShapes = new DrawingShapes();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Data1.RectangleShape rectangleShape = new Data1.RectangleShape(1, 1, 1, 1);
            //DataList.RectangleShape rectangleShape = new DataList.RectangleShape(1, 1, 1, 1);
            
        }

        private void radioButtonDrawRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDrawRectangle.Checked == true)
            {
                labelCircleRadius.Enabled = false;
                textBoxInputCircleRadius.Enabled = false;
                buttonCircleCreate.Enabled = false;

                labelRectangleSide.Enabled = true;
                textBoxInputSquareSide.Enabled = true;
                buttonSquareCreate.Enabled = true;
                
            }
        }

        private void radioButtonDrawCircle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDrawCircle.Checked == true)
            {
                labelRectangleSide.Enabled = false;
                textBoxInputSquareSide.Enabled = false;
                buttonSquareCreate.Enabled = false;

                labelCircleRadius.Enabled = true;
                textBoxInputCircleRadius.Enabled = true;
                buttonCircleCreate.Enabled = true;
            }
        }

        private void buttonSquareCreate_Click(object sender, EventArgs e)
        {
            string input = "";
            int randx, randy, squareSide;
            Random random1 = new Random();
            randx = random1.Next(0, pictureBox1.Size.Width - 100);
            Random random2 = new Random();
            randy = random2.Next(0, pictureBox1.Size.Height - 100);
            input = textBoxInputSquareSide.Text;
            squareSide = Convert.ToInt32(input);


            rect = new RectangleShape(randx, randy, squareSide, squareSide);

            //drawingShapes = new DrawingShapes();

            drawingShapes.AddToList(rect);


            DataList dataList = new DataList(drawingShapes);
            dataList.SerializeIt();
            //timer1.Enabled = true;

            //MessageBox.Show($"number of rectangles = {drawingShapes.GetListofRectangles.Count}");
            
            //drawingShapes.DrawShape();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if(drawingShapes != null)
            {
                foreach(RectangleShape rec in drawingShapes.GetListofRectangles)
                {

                    //drawingShapes.DrawShape(e);

                    Graphics g = e.Graphics;
                    g.FillRectangle(Brushes.Violet, rec.X, rec.Y, rec.Width, rec.Height);
                    g.DrawRectangle(Pens.Black, rec.X, rec.Y, rec.Width, rec.Height);
                }
                //Graphics graphics = e.Graphics;
                //Rectangle rectan = new Rectangle(rect.X, rect.Y, rect.Width, rect.Height);
                //PaintEventArgs paint = new PaintEventArgs(graphics, rectan);
                //drawingShapes.DrawShape(e);
            }
            Refresh();
            //Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show($"number of rectangles = {drawingShapes.GetListofRectangles.Count}");
            //MessageBox.Show("lalala");
        }
    }

    
}
