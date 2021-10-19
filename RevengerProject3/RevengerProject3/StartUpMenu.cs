using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RevengerProject3
{
    public partial class StartUpMenu : Form
    {
        public StartUpMenu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Board boardgame = new Board();
            boardgame.Show();
            //this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            InitialScreen iScreen = new InitialScreen();
            iScreen.Show();
            //this.Close();
        }
    }
}
