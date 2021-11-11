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
        public int ResearchLabSpotsAvailable { get; set; } = 5;
        public int BreakRoomSpotsAvailable { get; set; } = 5;
        public int GroupConferenceSpotsAvailable { get; set; } = 5;
        public int GuestPresentationSpotsAvailable { get; set; } = 5;
        public int PeerProgrammingSpotsAvailable { get; set; } = 5;
        public int ArchivesSpotsAvailable { get; set; } = 5;

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
            if (Program.c.player1.control)
            {
                Program.c.player1.WorkersAtResearchLab++;
                Program.c.player1.OfficeWorkers--;
            }
            else if (Program.c.player2.control)
            {
                Program.c.player2.WorkersAtResearchLab++;
                Program.c.player2.OfficeWorkers--;
            }
            else if (Program.c.player3.control)
            {
                Program.c.player3.WorkersAtResearchLab++;
                Program.c.player3.OfficeWorkers--;
            }
            else if (Program.c.player4.control)
            {
                Program.c.player4.WorkersAtResearchLab++;
                Program.c.player4.OfficeWorkers--;
            }
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
            if (Program.c.player1.control)
            {
                Program.c.player1.WorkersAtBreakRoom++;
                Program.c.player1.OfficeWorkers--;
            }
            else if (Program.c.player2.control)
            {
                Program.c.player2.WorkersAtBreakRoom++;
                Program.c.player2.OfficeWorkers--;
            }
            else if (Program.c.player3.control)
            {
                Program.c.player3.WorkersAtBreakRoom++;
                Program.c.player3.OfficeWorkers--;
            }
            else if (Program.c.player4.control)
            {
                Program.c.player4.WorkersAtBreakRoom++;
                Program.c.player4.OfficeWorkers--;
            }
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
            if (Program.c.player1.control)
            {
                Program.c.player1.WorkersAtGroupConference++;
                Program.c.player1.OfficeWorkers--;
            }
            else if (Program.c.player2.control)
            {
                Program.c.player2.WorkersAtGroupConference++;
                Program.c.player2.OfficeWorkers--;
            }
            else if (Program.c.player3.control)
            {
                Program.c.player3.WorkersAtGroupConference++;
                Program.c.player3.OfficeWorkers--;
            }
            else if (Program.c.player4.control)
            {
                Program.c.player4.WorkersAtGroupConference++;
                Program.c.player4.OfficeWorkers--;
            }
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
            if (Program.c.player1.control)
            {
                Program.c.player1.WorkersAtGuestPresentation++;
                Program.c.player1.OfficeWorkers--;
            }
            else if (Program.c.player2.control)
            {
                Program.c.player2.WorkersAtGuestPresentation++;
                Program.c.player2.OfficeWorkers--;
            }
            else if (Program.c.player3.control)
            {
                Program.c.player3.WorkersAtGuestPresentation++;
                Program.c.player3.OfficeWorkers--;
            }
            else if (Program.c.player4.control)
            {
                Program.c.player4.WorkersAtGuestPresentation++;
                Program.c.player4.OfficeWorkers--;
            }
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
            if (Program.c.player1.control)
            {
                Program.c.player1.WorkersAtPeerProgramming++;
                Program.c.player1.OfficeWorkers--;
            }
            else if (Program.c.player2.control)
            {
                Program.c.player2.WorkersAtPeerProgramming++;
                Program.c.player2.OfficeWorkers--;
            }
            else if (Program.c.player3.control)
            {
                Program.c.player3.WorkersAtPeerProgramming++;
                Program.c.player3.OfficeWorkers--;
            }
            else if (Program.c.player4.control)
            {
                Program.c.player4.WorkersAtPeerProgramming++;
                Program.c.player4.OfficeWorkers--;
            }
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
            if (Program.c.player1.control)
            {
                Program.c.player1.WorkersAtArchives++;
                Program.c.player1.OfficeWorkers--;
            }
            else if (Program.c.player2.control)
            {
                Program.c.player2.WorkersAtArchives++;
                Program.c.player2.OfficeWorkers--;
            }
            else if (Program.c.player3.control)
            {
                Program.c.player3.WorkersAtArchives++;
                Program.c.player3.OfficeWorkers--;
            }
            else if (Program.c.player4.control)
            {
                Program.c.player4.WorkersAtArchives++;
                Program.c.player4.OfficeWorkers--;
            }
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
            if(ResearchLabSpotsAvailable != 0)
                ResearchLabPlace.Enabled = true;
            if(GroupConferenceSpotsAvailable != 0)
                GroupConferencePlace.Enabled = true;
            if(BreakRoomSpotsAvailable != 0)
                BreakRoomPlace.Enabled = true;
            if(GuestPresentationSpotsAvailable != 0)
                GuestPresentationPlace.Enabled = true;
            if(PeerProgrammingSpotsAvailable != 0)
                PeerProgrammingPlace.Enabled = true;
            if(ArchivesSpotsAvailable != 0)
                ArchivesPlace.Enabled = true;

            if (Program.c.NumberOfPlayers == 2)
            {
                Program.c.ChangeControl();
                if (Program.c.roundEnded)
                    ResetBoard();
                if (Program.c.player1.control)
                    {
                        PlayerControlLabel.Text = Program.c.player1.Name.ToString() + " can place";
                    }
                else if (Program.c.player2.control)
                    {
                        PlayerControlLabel.Text = Program.c.player2.Name.ToString() + " can place";
                    }
            }
            else if (Program.c.NumberOfPlayers == 3)
            {
                Program.c.ChangeControl();
                if (Program.c.roundEnded)
                    ResetBoard();
                if (Program.c.player1.control)
                    {
                        PlayerControlLabel.Text = Program.c.player1.Name.ToString() + " can place";
                    }
                else if (Program.c.player2.control)
                    {
                        PlayerControlLabel.Text = Program.c.player2.Name.ToString() + " can place";
                    }
                else if (Program.c.player3.control)
                    {
                        PlayerControlLabel.Text = Program.c.player3.Name.ToString() + " can place";
                    }
            }
            else if (Program.c.NumberOfPlayers == 4)
            {
                Program.c.ChangeControl();
                if (Program.c.roundEnded)
                    ResetBoard();
                if (Program.c.player1.control)
                    {
                        PlayerControlLabel.Text = Program.c.player1.Name.ToString() + " can place";
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

        public void ResetBoard()
        {
            ResearchLabSpotsAvailable = 5;
            GroupConferenceSpotsAvailable = 5;
            GuestPresentationSpotsAvailable = 5;
            ArchivesSpotsAvailable = 5;
            BreakRoomSpotsAvailable = 5;
            PeerProgrammingSpotsAvailable = 5;
            ResearchLabSpotsLabel.Text = ResearchLabSpotsAvailable.ToString();
            BreakRoomSpotsLabel.Text = BreakRoomSpotsAvailable.ToString();
            GroupConferenceSpotsLabel.Text = GroupConferenceSpotsAvailable.ToString();
            GuestPresentationSpotsLabel.Text = GuestPresentationSpotsAvailable.ToString();
            PeerProgrammingSpotsLabel.Text = PeerProgrammingSpotsAvailable.ToString();
            ArchivesSpotsLabel.Text = ArchivesSpotsAvailable.ToString();
            PlayerControlLabel.Text = Program.c.player1.Name.ToString() + " can place";
            Program.c.roundEnded = false;
        }
    }
}
