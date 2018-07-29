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

namespace OOPFinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Data1.RectangleShape rectangleShape = new Data1.RectangleShape(1, 1, 1, 1);
            DataList.RectangleShape rectangleShape = new DataList.RectangleShape(1, 1, 1, 1);
        }


    }

    
}
