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
        int ResearchLabSpotsAvailable = 5;
        int BreakRoomSpotsAvailable = 5;
        int GroupConferenceSpotsAvailable = 5;
        int GuestPresentationSpotsAvailable = 5;
        int PeerProgrammingSpotsAvailable = 5;
        int ArchivesSpotsAvailable = 5;

        public Board()
        {
            InitializeComponent();
        }

        private void Board_Load(object sender, EventArgs e)
        {
            ResearchLabSpotsLabel.Text = ResearchLabSpotsAvailable.ToString();
            BreakRoomSpotsLabel.Text = BreakRoomSpotsAvailable.ToString();
            GroupConferenceSpotsLabel.Text = GroupConferenceSpotsAvailable.ToString();
            GuestPresentationSpotsLabel.Text = GuestPresentationSpotsAvailable.ToString();
            PeerProgrammingSpotsLabel.Text = PeerProgrammingSpotsAvailable.ToString();
            ArchivesSpotsLabel.Text = ArchivesSpotsAvailable.ToString();
            PlayerControlLabel.Text = Program.c.player1.Name.ToString() + " can place";
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

        private void ResearchLabPlace_Click(object sender, EventArgs e)
        {
            ResearchLabSpotsAvailable--;
            ResearchLabSpotsLabel.Text = ResearchLabSpotsAvailable.ToString();
            GuestPresentationPlace.Enabled = false;
            BreakRoomPlace.Enabled = false;
            GroupConferencePlace.Enabled = false;
            PeerProgrammingPlace.Enabled = false;
            ArchivesPlace.Enabled = false;
            if (ResearchLabSpotsAvailable == 0)
                ResearchLabPlace.Enabled = false;
        }

        private void BreakRoomPlace_Click(object sender, EventArgs e)
        {
            BreakRoomSpotsAvailable--;
            BreakRoomSpotsLabel.Text = BreakRoomSpotsAvailable.ToString();
            ResearchLabPlace.Enabled = false;
            GuestPresentationPlace.Enabled = false;
            GroupConferencePlace.Enabled = false;
            PeerProgrammingPlace.Enabled = false;
            ArchivesPlace.Enabled = false;
            if (BreakRoomSpotsAvailable == 0)
                BreakRoomPlace.Enabled = false;
        }

        private void GroupConferencePlace_Click(object sender, EventArgs e)
        {
            GroupConferenceSpotsAvailable--;
            GroupConferenceSpotsLabel.Text = GroupConferenceSpotsAvailable.ToString();
            ResearchLabPlace.Enabled = false;
            GuestPresentationPlace.Enabled = false;
            BreakRoomPlace.Enabled = false;
            PeerProgrammingPlace.Enabled = false;
            ArchivesPlace.Enabled = false;
            if (GroupConferenceSpotsAvailable == 0)
                GroupConferencePlace.Enabled = false;
        }

        private void GuestPresentationPlace_Click(object sender, EventArgs e)
        {
            GuestPresentationSpotsAvailable--;
            GuestPresentationSpotsLabel.Text = GuestPresentationSpotsAvailable.ToString();
            ResearchLabPlace.Enabled = false;
            GroupConferencePlace.Enabled = false;
            BreakRoomPlace.Enabled = false;
            PeerProgrammingPlace.Enabled = false;
            ArchivesPlace.Enabled = false;
            if (GuestPresentationSpotsAvailable == 0)
                GuestPresentationPlace.Enabled = false;
        }

        private void PeerProgrammingPlace_Click(object sender, EventArgs e)
        {
            PeerProgrammingSpotsAvailable--;
            PeerProgrammingSpotsLabel.Text = PeerProgrammingSpotsAvailable.ToString();
            ResearchLabPlace.Enabled = false;
            GroupConferencePlace.Enabled = false;
            BreakRoomPlace.Enabled = false;
            GuestPresentationPlace.Enabled = false;
            ArchivesPlace.Enabled = false;
            if (PeerProgrammingSpotsAvailable == 0)
                PeerProgrammingPlace.Enabled = false;
        }

        private void ArchivesPlace_Click(object sender, EventArgs e)
        {
            ArchivesSpotsAvailable--;
            ArchivesSpotsLabel.Text = ArchivesSpotsAvailable.ToString();
            ResearchLabPlace.Enabled = false;
            GroupConferencePlace.Enabled = false;
            BreakRoomPlace.Enabled = false;
            GuestPresentationPlace.Enabled = false;
            PeerProgrammingPlace.Enabled = false;
            if (ArchivesSpotsAvailable == 0)
                ArchivesPlace.Enabled = false;
        }

        private void EndPlacement_Click(object sender, EventArgs e)
        {
            Program.c.ChangeControl();
            if (Program.c.player1.control)
            {
                PlayerControlLabel.Text = Program.c.player1.Name.ToString()+" can place";
            }
            else if (Program.c.player2.control)
            {
                PlayerControlLabel.Text = Program.c.player2.Name.ToString() + " can place";
            }
            else if (Program.c.player3.control)
            {
                PlayerControlLabel.Text = Program.c.player3.Name.ToString() + " can place";
            }
            else if (Program.c.player4.control)
            {
                PlayerControlLabel.Text = Program.c.player4.Name.ToString() + " can place";
            }
        }
    }
}
