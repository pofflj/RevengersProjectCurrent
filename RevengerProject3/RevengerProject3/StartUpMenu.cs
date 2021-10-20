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
            //this.Hide();
            Board boardgame = new Board();
            boardgame.Show();
            //this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            InitialScreen iScreen = new InitialScreen();
            iScreen.Show();
            //this.Close();
        }
        
           
        private void numericUpDownForPlayers_ValueChanged(object sender, EventArgs e)
        {
            //numericUpDownForPlayers.UpButton();

            //numericUpDownForPlayers.Value = 0;
            
            if(numericUpDownForPlayers.Value == 1)
            {
                player1NameLabel.Show();
                PlayerOneTextBox.Show();
            }
            if(numericUpDownForPlayers.Value == 2)
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
            PlayerOneTextBox.Hide();
            playerTwoTextBox.Hide();
            playerThreeTextBox.Hide();
            playerFourTextBox.Hide();
            // Hide Labels in start up menu when loaded
            player1NameLabel.Hide();
            player2NameLabel.Hide();
            player3NameLabel.Hide();
            player4NameLabel.Hide();
        }
    }
}
