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
            this.Hide();
            Board boardgame = new Board();
            boardgame.FormClosed += (s, args) => this.Close();
            boardgame.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InitialScreen iScreen = new InitialScreen();
            iScreen.FormClosed += (s, args) => this.Close();
            iScreen.Show();
        }


        private void numericUpDownForPlayers_ValueChanged(object sender, EventArgs e)
        {
            player3NameLabel.Hide();
            playerThreeTextBox.Hide();
            player4NameLabel.Hide();
            playerFourTextBox.Hide();

            if (numericUpDownForPlayers.Value == 2)
            {
                player1NameLabel.Show();
                PlayerOneTextBox.Show();
                player2NameLabel.Show();
                playerTwoTextBox.Show();
            }
            if (numericUpDownForPlayers.Value == 3)
            {
                player1NameLabel.Show();
                PlayerOneTextBox.Show();
                player2NameLabel.Show();
                playerTwoTextBox.Show();
                player3NameLabel.Show();
                playerThreeTextBox.Show();
            }
            if (numericUpDownForPlayers.Value == 4)
            {
                player1NameLabel.Show();
                PlayerOneTextBox.Show();
                player2NameLabel.Show();
                playerTwoTextBox.Show();
                player3NameLabel.Show();
                playerThreeTextBox.Show();
                player4NameLabel.Show();
                playerFourTextBox.Show();
            }
        }

        private void StartUpMenu_Load(object sender, EventArgs e)
        {
            //Hide text boxes in start up menu when loaded
            playerThreeTextBox.Hide();
            playerFourTextBox.Hide();
            // Hide Labels in start up menu when loaded
            player3NameLabel.Hide();
            player4NameLabel.Hide();
        }
    }
}
