namespace RevengerProject3
{
    partial class Board
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ResearchLabPlace = new System.Windows.Forms.Button();
            this.GuestPresentationPlace = new System.Windows.Forms.Button();
            this.BreakRoomPlace = new System.Windows.Forms.Button();
            this.PeerProgrammingPlace = new System.Windows.Forms.Button();
            this.GroupConferencePlace = new System.Windows.Forms.Button();
            this.ArchivesPlace = new System.Windows.Forms.Button();
            this.ResearchLabSpotsLabel = new System.Windows.Forms.Label();
            this.GuestPresentationSpotsLabel = new System.Windows.Forms.Label();
            this.BreakRoomSpotsLabel = new System.Windows.Forms.Label();
            this.PeerProgrammingSpotsLabel = new System.Windows.Forms.Label();
            this.GroupConferenceSpotsLabel = new System.Windows.Forms.Label();
            this.ArchivesSpotsLabel = new System.Windows.Forms.Label();
            this.PlayerControlLabel = new System.Windows.Forms.Label();
            this.EndPlacement = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Break Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peer Programming";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Guest Presentation";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(677, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Group Conference";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(691, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Archives";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Research Lab";
            // 
            // ResearchLabPlace
            // 
            this.ResearchLabPlace.Location = new System.Drawing.Point(203, 45);
            this.ResearchLabPlace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResearchLabPlace.Name = "ResearchLabPlace";
            this.ResearchLabPlace.Size = new System.Drawing.Size(86, 31);
            this.ResearchLabPlace.TabIndex = 7;
            this.ResearchLabPlace.Text = "Place";
            this.ResearchLabPlace.UseVisualStyleBackColor = true;
            this.ResearchLabPlace.Click += new System.EventHandler(this.ResearchLabPlace_Click);
            // 
            // GuestPresentationPlace
            // 
            this.GuestPresentationPlace.Location = new System.Drawing.Point(72, 340);
            this.GuestPresentationPlace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GuestPresentationPlace.Name = "GuestPresentationPlace";
            this.GuestPresentationPlace.Size = new System.Drawing.Size(86, 31);
            this.GuestPresentationPlace.TabIndex = 8;
            this.GuestPresentationPlace.Text = "Place";
            this.GuestPresentationPlace.UseVisualStyleBackColor = true;
            this.GuestPresentationPlace.Click += new System.EventHandler(this.GuestPresentationPlace_Click);
            // 
            // BreakRoomPlace
            // 
            this.BreakRoomPlace.Location = new System.Drawing.Point(496, 140);
            this.BreakRoomPlace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BreakRoomPlace.Name = "BreakRoomPlace";
            this.BreakRoomPlace.Size = new System.Drawing.Size(86, 31);
            this.BreakRoomPlace.TabIndex = 9;
            this.BreakRoomPlace.Text = "Place";
            this.BreakRoomPlace.UseVisualStyleBackColor = true;
            this.BreakRoomPlace.Click += new System.EventHandler(this.BreakRoomPlace_Click);
            // 
            // PeerProgrammingPlace
            // 
            this.PeerProgrammingPlace.Location = new System.Drawing.Point(345, 461);
            this.PeerProgrammingPlace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PeerProgrammingPlace.Name = "PeerProgrammingPlace";
            this.PeerProgrammingPlace.Size = new System.Drawing.Size(86, 31);
            this.PeerProgrammingPlace.TabIndex = 10;
            this.PeerProgrammingPlace.Text = "Place";
            this.PeerProgrammingPlace.UseVisualStyleBackColor = true;
            this.PeerProgrammingPlace.Click += new System.EventHandler(this.PeerProgrammingPlace_Click);
            // 
            // GroupConferencePlace
            // 
            this.GroupConferencePlace.Location = new System.Drawing.Point(691, 192);
            this.GroupConferencePlace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupConferencePlace.Name = "GroupConferencePlace";
            this.GroupConferencePlace.Size = new System.Drawing.Size(86, 31);
            this.GroupConferencePlace.TabIndex = 11;
            this.GroupConferencePlace.Text = "Place";
            this.GroupConferencePlace.UseVisualStyleBackColor = true;
            this.GroupConferencePlace.Click += new System.EventHandler(this.GroupConferencePlace_Click);
            // 
            // ArchivesPlace
            // 
            this.ArchivesPlace.Location = new System.Drawing.Point(677, 461);
            this.ArchivesPlace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ArchivesPlace.Name = "ArchivesPlace";
            this.ArchivesPlace.Size = new System.Drawing.Size(86, 31);
            this.ArchivesPlace.TabIndex = 12;
            this.ArchivesPlace.Text = "Place";
            this.ArchivesPlace.UseVisualStyleBackColor = true;
            this.ArchivesPlace.Click += new System.EventHandler(this.ArchivesPlace_Click);
            // 
            // ResearchLabSpotsLabel
            // 
            this.ResearchLabSpotsLabel.AutoSize = true;
            this.ResearchLabSpotsLabel.Location = new System.Drawing.Point(296, 51);
            this.ResearchLabSpotsLabel.Name = "ResearchLabSpotsLabel";
            this.ResearchLabSpotsLabel.Size = new System.Drawing.Size(17, 20);
            this.ResearchLabSpotsLabel.TabIndex = 13;
            this.ResearchLabSpotsLabel.Text = "0";
            // 
            // GuestPresentationSpotsLabel
            // 
            this.GuestPresentationSpotsLabel.AutoSize = true;
            this.GuestPresentationSpotsLabel.Location = new System.Drawing.Point(165, 345);
            this.GuestPresentationSpotsLabel.Name = "GuestPresentationSpotsLabel";
            this.GuestPresentationSpotsLabel.Size = new System.Drawing.Size(17, 20);
            this.GuestPresentationSpotsLabel.TabIndex = 14;
            this.GuestPresentationSpotsLabel.Text = "0";
            // 
            // BreakRoomSpotsLabel
            // 
            this.BreakRoomSpotsLabel.AutoSize = true;
            this.BreakRoomSpotsLabel.Location = new System.Drawing.Point(589, 145);
            this.BreakRoomSpotsLabel.Name = "BreakRoomSpotsLabel";
            this.BreakRoomSpotsLabel.Size = new System.Drawing.Size(17, 20);
            this.BreakRoomSpotsLabel.TabIndex = 15;
            this.BreakRoomSpotsLabel.Text = "0";
            // 
            // PeerProgrammingSpotsLabel
            // 
            this.PeerProgrammingSpotsLabel.AutoSize = true;
            this.PeerProgrammingSpotsLabel.Location = new System.Drawing.Point(438, 467);
            this.PeerProgrammingSpotsLabel.Name = "PeerProgrammingSpotsLabel";
            this.PeerProgrammingSpotsLabel.Size = new System.Drawing.Size(17, 20);
            this.PeerProgrammingSpotsLabel.TabIndex = 16;
            this.PeerProgrammingSpotsLabel.Text = "0";
            // 
            // GroupConferenceSpotsLabel
            // 
            this.GroupConferenceSpotsLabel.AutoSize = true;
            this.GroupConferenceSpotsLabel.Location = new System.Drawing.Point(784, 197);
            this.GroupConferenceSpotsLabel.Name = "GroupConferenceSpotsLabel";
            this.GroupConferenceSpotsLabel.Size = new System.Drawing.Size(17, 20);
            this.GroupConferenceSpotsLabel.TabIndex = 17;
            this.GroupConferenceSpotsLabel.Text = "0";
            // 
            // ArchivesSpotsLabel
            // 
            this.ArchivesSpotsLabel.AutoSize = true;
            this.ArchivesSpotsLabel.Location = new System.Drawing.Point(769, 467);
            this.ArchivesSpotsLabel.Name = "ArchivesSpotsLabel";
            this.ArchivesSpotsLabel.Size = new System.Drawing.Size(17, 20);
            this.ArchivesSpotsLabel.TabIndex = 18;
            this.ArchivesSpotsLabel.Text = "0";
            // 
            // PlayerControlLabel
            // 
            this.PlayerControlLabel.AutoSize = true;
            this.PlayerControlLabel.Location = new System.Drawing.Point(399, 12);
            this.PlayerControlLabel.Name = "PlayerControlLabel";
            this.PlayerControlLabel.Size = new System.Drawing.Size(128, 20);
            this.PlayerControlLabel.TabIndex = 19;
            this.PlayerControlLabel.Text = "Player 1 can place";
            // 
            // EndPlacement
            // 
            this.EndPlacement.Location = new System.Drawing.Point(881, 527);
            this.EndPlacement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EndPlacement.Name = "EndPlacement";
            this.EndPlacement.Size = new System.Drawing.Size(86, 31);
            this.EndPlacement.TabIndex = 20;
            this.EndPlacement.Text = "Done";
            this.EndPlacement.UseVisualStyleBackColor = true;
            this.EndPlacement.Click += new System.EventHandler(this.EndPlacement_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 511);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 29);
            this.button3.TabIndex = 23;
            this.button3.Text = "Player Cards";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 571);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.EndPlacement);
            this.Controls.Add(this.PlayerControlLabel);
            this.Controls.Add(this.ArchivesSpotsLabel);
            this.Controls.Add(this.GroupConferenceSpotsLabel);
            this.Controls.Add(this.PeerProgrammingSpotsLabel);
            this.Controls.Add(this.BreakRoomSpotsLabel);
            this.Controls.Add(this.GuestPresentationSpotsLabel);
            this.Controls.Add(this.ResearchLabSpotsLabel);
            this.Controls.Add(this.ArchivesPlace);
            this.Controls.Add(this.GroupConferencePlace);
            this.Controls.Add(this.PeerProgrammingPlace);
            this.Controls.Add(this.BreakRoomPlace);
            this.Controls.Add(this.GuestPresentationPlace);
            this.Controls.Add(this.ResearchLabPlace);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Board";
            this.Text = "Board";
            this.Load += new System.EventHandler(this.Board_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ResearchLabPlace;
        private System.Windows.Forms.Button GuestPresentationPlace;
        private System.Windows.Forms.Button BreakRoomPlace;
        private System.Windows.Forms.Button PeerProgrammingPlace;
        private System.Windows.Forms.Button GroupConferencePlace;
        private System.Windows.Forms.Button ArchivesPlace;
        private System.Windows.Forms.Label ResearchLabSpotsLabel;
        private System.Windows.Forms.Label GuestPresentationSpotsLabel;
        private System.Windows.Forms.Label BreakRoomSpotsLabel;
        private System.Windows.Forms.Label PeerProgrammingSpotsLabel;
        private System.Windows.Forms.Label GroupConferenceSpotsLabel;
        private System.Windows.Forms.Label ArchivesSpotsLabel;
        private System.Windows.Forms.Label PlayerControlLabel;
        private System.Windows.Forms.Button EndPlacement;
        private System.Windows.Forms.Button button3;
    }
}