using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RevengerProject3
{
    public partial class PlayerCardForAll : Form
    {
        public PlayerCardForAll()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
        public void updatePlayerCard()
        {
            if (Program.c.NumberOfPlayers == 2)
            {
                //player 1 values
                p1aw.Text = Program.c.player1.OfficeWorkers.ToString();
                p1class.Text = Program.c.player1.Classes.ToString();
                p1mor.Text = Program.c.player1.Morale.ToString();
                p1re.Text = Program.c.player1.Research.ToString();
                p1rest.Text = Program.c.player1.Rest.ToString();
                //player 2 values
                p2aw.Text = Program.c.player2.OfficeWorkers.ToString();
                p2class.Text = Program.c.player2.Classes.ToString();
                p2mor.Text = Program.c.player2.Morale.ToString();
                p2re.Text = Program.c.player2.Research.ToString();
                p2rest.Text = Program.c.player2.Rest.ToString();
            }
            else if (Program.c.NumberOfPlayers == 3)
            {
                //player 1 values
                p1aw.Text = Program.c.player1.OfficeWorkers.ToString();
                p1class.Text = Program.c.player1.Classes.ToString();
                p1mor.Text = Program.c.player1.Morale.ToString();
                p1re.Text = Program.c.player1.Research.ToString();
                p1rest.Text = Program.c.player1.Rest.ToString();
                //player 2 values
                p2aw.Text = Program.c.player2.OfficeWorkers.ToString();
                p2class.Text = Program.c.player2.Classes.ToString();
                p2mor.Text = Program.c.player2.Morale.ToString();
                p2re.Text = Program.c.player2.Research.ToString();
                p2rest.Text = Program.c.player2.Rest.ToString();
                //player 3 values
                p3aw.Text = Program.c.player3.OfficeWorkers.ToString();
                p3class.Text = Program.c.player3.Classes.ToString();
                p3mor.Text = Program.c.player3.Morale.ToString();
                p3re.Text = Program.c.player3.Research.ToString();
                p3rest.Text = Program.c.player3.Rest.ToString();
            }
            else
            {
                //player 1 values
                p1aw.Text = Program.c.player1.OfficeWorkers.ToString();
                p1class.Text = Program.c.player1.Classes.ToString();
                p1mor.Text = Program.c.player1.Morale.ToString();
                p1re.Text = Program.c.player1.Research.ToString();
                p1rest.Text = Program.c.player1.Rest.ToString();
                //player 2 values
                p2aw.Text = Program.c.player2.OfficeWorkers.ToString();
                p2class.Text = Program.c.player2.Classes.ToString();
                p2mor.Text = Program.c.player2.Morale.ToString();
                p2re.Text = Program.c.player2.Research.ToString();
                p2rest.Text = Program.c.player2.Rest.ToString();
                //player 3 values
                p3aw.Text = Program.c.player3.OfficeWorkers.ToString();
                p3class.Text = Program.c.player3.Classes.ToString();
                p3mor.Text = Program.c.player3.Morale.ToString();
                p3re.Text = Program.c.player3.Research.ToString();
                p3rest.Text = Program.c.player3.Rest.ToString();
                //player 4 values
                p4aw.Text = Program.c.player4.OfficeWorkers.ToString();
                p4class.Text = Program.c.player4.Classes.ToString();
                p4mor.Text = Program.c.player4.Morale.ToString();
                p4re.Text = Program.c.player4.Research.ToString();
                p4rest.Text = Program.c.player4.Rest.ToString();
            }
                


        }
        private void PlayerCardForAll_Load(object sender, EventArgs e)
        {
            
            ControlBox = false;
            if(Program.c.NumberOfPlayers == 2)
            {
                p1Name.Text = Program.c.player1.Name;
                p2Name.Text = Program.c.player2.Name;
                p3aw.Hide();
                p3class.Hide();
                p3mor.Hide();
                p3Name.Hide();
                p3re.Hide();
                p3rest.Hide();
                p4class.Hide();
                p4mor.Hide();
                p4Name.Hide();
                p4re.Hide();
                p4rest.Hide();
                p4aw.Hide();

            }
            else if(Program.c.NumberOfPlayers == 3)
            {
                p1Name.Text = Program.c.player1.Name;
                p2Name.Text = Program.c.player2.Name;
                p3Name.Text = Program.c.player3.Name;
                p4class.Hide();
                p4mor.Hide();
                p4Name.Hide();
                p4re.Hide();
                p4rest.Hide();
                p4aw.Hide();
            }
            else
            {
                p1Name.Text = Program.c.player1.Name;
                p2Name.Text = Program.c.player2.Name;
                p3Name.Text = Program.c.player3.Name;
                p4Name.Text = Program.c.player4.Name;

            }


            //p3Name.Text = Program.c.player3.Name;
            //p4Name.Text = Program.c.player4.Name;
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
