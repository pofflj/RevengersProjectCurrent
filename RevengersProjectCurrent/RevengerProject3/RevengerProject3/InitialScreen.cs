using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RevengerProject3
{
    public partial class InitialScreen : Form
    {
        public InitialScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartUpMenu Menu = new StartUpMenu();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rules r = new Rules();
            r.FormClosed += (s, args) => this.Close();
            r.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
