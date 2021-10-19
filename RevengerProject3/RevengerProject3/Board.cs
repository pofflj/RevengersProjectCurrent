using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RevengerProject3
{
    public partial class Board : Form
    {
        public Board()
        {
            InitializeComponent();
        }

        private void Board_Load(object sender, EventArgs e)
        {
            //BackgroundImage = System.Drawing.Image.FromFile("C:/Users/lukep/Software Engeneering 1/BoardForOffice.png");
            //this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        private void label3_Paint(object sender, PaintEventArgs e)
        {
            /*
            e.Graphics.TranslateTransform(pt.X, pt.Y);
            e.Graphics.RotateTransform(deg);//set rotation
            e.Graphics.DrawString("Label1", myFont, myBrush, 0, 0);
            */
        }

    }
}
