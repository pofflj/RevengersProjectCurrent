using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RevengerProject3
{
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            InitialScreen iScreen = new InitialScreen();
            iScreen.FormClosed += (s, args) => this.Close();
            iScreen.Show();
        }
    }
}
