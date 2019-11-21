namespace StreetFight
{
    partial class MainMenu
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
            this.MainMenuLabel = new System.Windows.Forms.Label();
            this.NewFighterButton = new System.Windows.Forms.Button();
            this.LoadFighterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenuLabel
            // 
            this.MainMenuLabel.AutoSize = true;
            this.MainMenuLabel.Location = new System.Drawing.Point(170, 42);
            this.MainMenuLabel.Name = "MainMenuLabel";
            this.MainMenuLabel.Size = new System.Drawing.Size(57, 13);
            this.MainMenuLabel.TabIndex = 0;
            this.MainMenuLabel.Text = "MainMenu";
            this.MainMenuLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewFighterButton
            // 
            this.NewFighterButton.Location = new System.Drawing.Point(139, 104);
            this.NewFighterButton.Name = "NewFighterButton";
            this.NewFighterButton.Size = new System.Drawing.Size(121, 23);
            this.NewFighterButton.TabIndex = 1;
            this.NewFighterButton.Text = "NewFighter";
            this.NewFighterButton.UseVisualStyleBackColor = true;
            this.NewFighterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoadFighterButton
            // 
            this.LoadFighterButton.Location = new System.Drawing.Point(139, 156);
            this.LoadFighterButton.Name = "LoadFighterButton";
            this.LoadFighterButton.Size = new System.Drawing.Size(121, 23);
            this.LoadFighterButton.TabIndex = 2;
            this.LoadFighterButton.Text = "LoadFighter";
            this.LoadFighterButton.UseVisualStyleBackColor = true;
            this.LoadFighterButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 360);
            this.Controls.Add(this.LoadFighterButton);
            this.Controls.Add(this.NewFighterButton);
            this.Controls.Add(this.MainMenuLabel);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainMenuLabel;
        private System.Windows.Forms.Button NewFighterButton;
        private System.Windows.Forms.Button LoadFighterButton;
    }
}

