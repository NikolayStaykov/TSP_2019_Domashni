namespace StreetFight
{
    partial class LoadFighters
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
            this.FightersListBox = new System.Windows.Forms.ListBox();
            this.SelectFighter = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FightersListBox
            // 
            this.FightersListBox.FormattingEnabled = true;
            this.FightersListBox.Location = new System.Drawing.Point(12, 12);
            this.FightersListBox.Name = "FightersListBox";
            this.FightersListBox.Size = new System.Drawing.Size(281, 173);
            this.FightersListBox.TabIndex = 0;
            this.FightersListBox.SelectedIndexChanged += new System.EventHandler(this.FightersListBox_SelectedIndexChanged);
            // 
            // SelectFighter
            // 
            this.SelectFighter.Location = new System.Drawing.Point(13, 228);
            this.SelectFighter.Name = "SelectFighter";
            this.SelectFighter.Size = new System.Drawing.Size(106, 23);
            this.SelectFighter.TabIndex = 1;
            this.SelectFighter.Text = "Select";
            this.SelectFighter.UseVisualStyleBackColor = true;
            this.SelectFighter.Click += new System.EventHandler(this.SelectFighter_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(187, 228);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(106, 23);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // LoadFighters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 285);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.SelectFighter);
            this.Controls.Add(this.FightersListBox);
            this.Name = "LoadFighters";
            this.Text = "LoadFighters";
            this.Load += new System.EventHandler(this.LoadFighters_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FightersListBox;
        private System.Windows.Forms.Button SelectFighter;
        private System.Windows.Forms.Button QuitButton;
    }
}