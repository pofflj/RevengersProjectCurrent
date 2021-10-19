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
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownForPlayers = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(157, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 1 Name";
            // 
            // numericUpDownForPlayers
            // 
            this.numericUpDownForPlayers.Location = new System.Drawing.Point(279, 148);
            this.numericUpDownForPlayers.Name = "numericUpDownForPlayers";
            this.numericUpDownForPlayers.Size = new System.Drawing.Size(41, 27);
            this.numericUpDownForPlayers.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Player 2 Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Player 3 Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Player 4 Name";
            // 
            // PlayerOneTextBox
            // 
            this.PlayerOneTextBox.Location = new System.Drawing.Point(268, 215);
            this.PlayerOneTextBox.Name = "PlayerOneTextBox";
            this.PlayerOneTextBox.Size = new System.Drawing.Size(125, 27);
            this.PlayerOneTextBox.TabIndex = 3;
            // 
            // playerFourTextBox
            // 
            this.playerFourTextBox.Location = new System.Drawing.Point(556, 308);
            this.playerFourTextBox.Name = "playerFourTextBox";
            this.playerFourTextBox.Size = new System.Drawing.Size(125, 27);
            this.playerFourTextBox.TabIndex = 3;
            // 
            // playerThreeTextBox
            // 
            this.playerThreeTextBox.Location = new System.Drawing.Point(556, 215);
            this.playerThreeTextBox.Name = "playerThreeTextBox";
            this.playerThreeTextBox.Size = new System.Drawing.Size(125, 27);
            this.playerThreeTextBox.TabIndex = 3;
            // 
            // playerTwoTextBox
            // 
            this.playerTwoTextBox.Location = new System.Drawing.Point(268, 308);
            this.playerTwoTextBox.Name = "playerTwoTextBox";
            this.playerTwoTextBox.Size = new System.Drawing.Size(125, 27);
            this.playerTwoTextBox.TabIndex = 3;
            // 
            // startUpMenuReturnButton
            // 
            this.startUpMenuReturnButton.Location = new System.Drawing.Point(268, 407);
            this.startUpMenuReturnButton.Name = "startUpMenuReturnButton";
            this.startUpMenuReturnButton.Size = new System.Drawing.Size(94, 29);
            this.startUpMenuReturnButton.TabIndex = 4;
            this.startUpMenuReturnButton.Text = "Return";
            this.startUpMenuReturnButton.UseVisualStyleBackColor = true;
            this.startUpMenuReturnButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // startUpMenuStartButton
            // 
            this.startUpMenuStartButton.Location = new System.Drawing.Point(556, 407);
            this.startUpMenuStartButton.Name = "startUpMenuStartButton";
            this.startUpMenuStartButton.Size = new System.Drawing.Size(94, 29);
            this.startUpMenuStartButton.TabIndex = 5;
            this.startUpMenuStartButton.Text = "Start Game";
            this.startUpMenuStartButton.UseVisualStyleBackColor = true;
            this.startUpMenuStartButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // StartUpMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 497);
            this.Controls.Add(this.startUpMenuStartButton);
            this.Controls.Add(this.startUpMenuReturnButton);
            this.Controls.Add(this.playerTwoTextBox);
            this.Controls.Add(this.playerThreeTextBox);
            this.Controls.Add(this.playerFourTextBox);
            this.Controls.Add(this.PlayerOneTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownForPlayers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StartUpMenu";
            this.Text = "StartUpMenu";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownForPlayers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PlayerOneTextBox;
        private System.Windows.Forms.TextBox playerFourTextBox;
        private System.Windows.Forms.TextBox playerThreeTextBox;
        private System.Windows.Forms.TextBox playerTwoTextBox;
        private System.Windows.Forms.Button startUpMenuReturnButton;
        private System.Windows.Forms.Button startUpMenuStartButton;
    }
}