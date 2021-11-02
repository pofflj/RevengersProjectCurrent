namespace RevengerProject3
{
    partial class StartUpMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.player1NameLabel = new System.Windows.Forms.Label();
            this.numericUpDownForPlayers = new System.Windows.Forms.NumericUpDown();
            this.player2NameLabel = new System.Windows.Forms.Label();
            this.player3NameLabel = new System.Windows.Forms.Label();
            this.player4NameLabel = new System.Windows.Forms.Label();
            this.PlayerOneTextBox = new System.Windows.Forms.TextBox();
            this.playerFourTextBox = new System.Windows.Forms.TextBox();
            this.playerThreeTextBox = new System.Windows.Forms.TextBox();
            this.playerTwoTextBox = new System.Windows.Forms.TextBox();
            this.startUpMenuReturnButton = new System.Windows.Forms.Button();
            this.startUpMenuStartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Amount";
            // 
            // player1NameLabel
            // 
            this.player1NameLabel.AutoSize = true;
            this.player1NameLabel.Location = new System.Drawing.Point(137, 166);
            this.player1NameLabel.Name = "player1NameLabel";
            this.player1NameLabel.Size = new System.Drawing.Size(83, 15);
            this.player1NameLabel.TabIndex = 1;
            this.player1NameLabel.Text = "Player 1 Name";
            // 
            // numericUpDownForPlayers
            // 
            this.numericUpDownForPlayers.Location = new System.Drawing.Point(244, 111);
            this.numericUpDownForPlayers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownForPlayers.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownForPlayers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownForPlayers.Name = "numericUpDownForPlayers";
            this.numericUpDownForPlayers.Size = new System.Drawing.Size(36, 23);
            this.numericUpDownForPlayers.TabIndex = 2;
            this.numericUpDownForPlayers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownForPlayers.ValueChanged += new System.EventHandler(this.numericUpDownForPlayers_ValueChanged);
            // 
            // player2NameLabel
            // 
            this.player2NameLabel.AutoSize = true;
            this.player2NameLabel.Location = new System.Drawing.Point(137, 236);
            this.player2NameLabel.Name = "player2NameLabel";
            this.player2NameLabel.Size = new System.Drawing.Size(83, 15);
            this.player2NameLabel.TabIndex = 1;
            this.player2NameLabel.Text = "Player 2 Name";
            this.player2NameLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // player3NameLabel
            // 
            this.player3NameLabel.AutoSize = true;
            this.player3NameLabel.Location = new System.Drawing.Point(377, 166);
            this.player3NameLabel.Name = "player3NameLabel";
            this.player3NameLabel.Size = new System.Drawing.Size(83, 15);
            this.player3NameLabel.TabIndex = 1;
            this.player3NameLabel.Text = "Player 3 Name";
            // 
            // player4NameLabel
            // 
            this.player4NameLabel.AutoSize = true;
            this.player4NameLabel.Location = new System.Drawing.Point(377, 236);
            this.player4NameLabel.Name = "player4NameLabel";
            this.player4NameLabel.Size = new System.Drawing.Size(83, 15);
            this.player4NameLabel.TabIndex = 1;
            this.player4NameLabel.Text = "Player 4 Name";
            // 
            // PlayerOneTextBox
            // 
            this.PlayerOneTextBox.Location = new System.Drawing.Point(234, 161);
            this.PlayerOneTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerOneTextBox.Name = "PlayerOneTextBox";
            this.PlayerOneTextBox.Size = new System.Drawing.Size(110, 23);
            this.PlayerOneTextBox.TabIndex = 3;
            // 
            // playerFourTextBox
            // 
            this.playerFourTextBox.Location = new System.Drawing.Point(486, 231);
            this.playerFourTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerFourTextBox.Name = "playerFourTextBox";
            this.playerFourTextBox.Size = new System.Drawing.Size(110, 23);
            this.playerFourTextBox.TabIndex = 3;
            // 
            // playerThreeTextBox
            // 
            this.playerThreeTextBox.Location = new System.Drawing.Point(486, 161);
            this.playerThreeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerThreeTextBox.Name = "playerThreeTextBox";
            this.playerThreeTextBox.Size = new System.Drawing.Size(110, 23);
            this.playerThreeTextBox.TabIndex = 3;
            // 
            // playerTwoTextBox
            // 
            this.playerTwoTextBox.Location = new System.Drawing.Point(234, 231);
            this.playerTwoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerTwoTextBox.Name = "playerTwoTextBox";
            this.playerTwoTextBox.Size = new System.Drawing.Size(110, 23);
            this.playerTwoTextBox.TabIndex = 3;
            // 
            // startUpMenuReturnButton
            // 
            this.startUpMenuReturnButton.Location = new System.Drawing.Point(234, 305);
            this.startUpMenuReturnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startUpMenuReturnButton.Name = "startUpMenuReturnButton";
            this.startUpMenuReturnButton.Size = new System.Drawing.Size(82, 22);
            this.startUpMenuReturnButton.TabIndex = 4;
            this.startUpMenuReturnButton.Text = "Return";
            this.startUpMenuReturnButton.UseVisualStyleBackColor = true;
            this.startUpMenuReturnButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // startUpMenuStartButton
            // 
            this.startUpMenuStartButton.Location = new System.Drawing.Point(486, 305);
            this.startUpMenuStartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startUpMenuStartButton.Name = "startUpMenuStartButton";
            this.startUpMenuStartButton.Size = new System.Drawing.Size(82, 22);
            this.startUpMenuStartButton.TabIndex = 5;
            this.startUpMenuStartButton.Text = "Start Game";
            this.startUpMenuStartButton.UseVisualStyleBackColor = true;
            this.startUpMenuStartButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // StartUpMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 373);
            this.Controls.Add(this.startUpMenuStartButton);
            this.Controls.Add(this.startUpMenuReturnButton);
            this.Controls.Add(this.playerTwoTextBox);
            this.Controls.Add(this.playerThreeTextBox);
            this.Controls.Add(this.playerFourTextBox);
            this.Controls.Add(this.PlayerOneTextBox);
            this.Controls.Add(this.player4NameLabel);
            this.Controls.Add(this.player3NameLabel);
            this.Controls.Add(this.player2NameLabel);
            this.Controls.Add(this.numericUpDownForPlayers);
            this.Controls.Add(this.player1NameLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StartUpMenu";
            this.Text = "StartUpMenu";
            this.Load += new System.EventHandler(this.StartUpMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label player1NameLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownForPlayers;
        private System.Windows.Forms.Label player2NameLabel;
        private System.Windows.Forms.Label player3NameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PlayerOneTextBox;
        private System.Windows.Forms.TextBox playerFourTextBox;
        private System.Windows.Forms.TextBox playerThreeTextBox;
        private System.Windows.Forms.TextBox playerTwoTextBox;
        private System.Windows.Forms.Button startUpMenuReturnButton;
        private System.Windows.Forms.Button startUpMenuStartButton;
        private System.Windows.Forms.Label player4NameLabel;
    }
}