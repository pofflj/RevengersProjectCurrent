using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start_Screen_and_Game_Screen
{
    public partial class GameStartingMenu : Form
    {
        public GameStartingMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LoadGame(object sender, EventArgs e)
        {
            GameScreen gameWindow = new GameScreen();
            gameWindow.Show();

        }

        private void LoadRules(object sender, EventArgs e)
        {

            Rules rules = new Rules();
            rules.Show();

        }

        private void ExitGame(object sender, EventArgs e)
        {
            Close();
        }
    }
}
