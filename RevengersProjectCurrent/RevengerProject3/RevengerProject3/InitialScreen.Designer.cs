namespace RevengerProject3
{
    partial class InitialScreen
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
            this.initialScreenStartGameButton = new System.Windows.Forms.Button();
            this.initialScreenRulesButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // initialScreenStartGameButton
            // 
            this.initialScreenStartGameButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.initialScreenStartGameButton.Location = new System.Drawing.Point(360, 103);
            this.initialScreenStartGameButton.Name = "initialScreenStartGameButton";
            this.initialScreenStartGameButton.Size = new System.Drawing.Size(94, 29);
            this.initialScreenStartGameButton.TabIndex = 0;
            this.initialScreenStartGameButton.Text = "Start Game";
            this.initialScreenStartGameButton.UseVisualStyleBackColor = false;
            this.initialScreenStartGameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // initialScreenRulesButton
            // 
            this.initialScreenRulesButton.Location = new System.Drawing.Point(360, 155);
            this.initialScreenRulesButton.Name = "initialScreenRulesButton";
            this.initialScreenRulesButton.Size = new System.Drawing.Size(94, 29);
            this.initialScreenRulesButton.TabIndex = 1;
            this.initialScreenRulesButton.Text = "Rules";
            this.initialScreenRulesButton.UseVisualStyleBackColor = true;
            this.initialScreenRulesButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(360, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // InitialScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.initialScreenRulesButton);
            this.Controls.Add(this.initialScreenStartGameButton);
            this.Name = "InitialScreen";
            this.Text = "InitialScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button initialScreenStartGameButton;
        private System.Windows.Forms.Button initialScreenRulesButton;
        private System.Windows.Forms.Button button3;
    }
}