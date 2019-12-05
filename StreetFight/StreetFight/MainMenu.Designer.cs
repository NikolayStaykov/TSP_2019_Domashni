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
            this.mainMenuLabel = new System.Windows.Forms.Label();
            this.NewFighter = new System.Windows.Forms.Button();
            this.LoadFighter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenuLabel
            // 
            this.mainMenuLabel.AutoSize = true;
            this.mainMenuLabel.Location = new System.Drawing.Point(185, 56);
            this.mainMenuLabel.Name = "mainMenuLabel";
            this.mainMenuLabel.Size = new System.Drawing.Size(60, 13);
            this.mainMenuLabel.TabIndex = 0;
            this.mainMenuLabel.Text = "Main Menu";
            this.mainMenuLabel.UseMnemonic = false;
            // 
            // NewFighter
            // 
            this.NewFighter.Location = new System.Drawing.Point(161, 108);
            this.NewFighter.Name = "NewFighter";
            this.NewFighter.Size = new System.Drawing.Size(109, 23);
            this.NewFighter.TabIndex = 1;
            this.NewFighter.Text = "New Fighter";
            this.NewFighter.UseVisualStyleBackColor = true;
            this.NewFighter.Click += new System.EventHandler(this.NewFighter_Click);
            // 
            // LoadFighter
            // 
            this.LoadFighter.Location = new System.Drawing.Point(161, 184);
            this.LoadFighter.Name = "LoadFighter";
            this.LoadFighter.Size = new System.Drawing.Size(109, 23);
            this.LoadFighter.TabIndex = 2;
            this.LoadFighter.Text = "Load Fighter";
            this.LoadFighter.UseVisualStyleBackColor = true;
            this.LoadFighter.Click += new System.EventHandler(this.LoadFighter_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 364);
            this.Controls.Add(this.LoadFighter);
            this.Controls.Add(this.NewFighter);
            this.Controls.Add(this.mainMenuLabel);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainMenuLabel;
        private System.Windows.Forms.Button NewFighter;
        private System.Windows.Forms.Button LoadFighter;
    }
}