namespace StreetFight
{
    partial class MainGame
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
            this.PlayerName = new System.Windows.Forms.Label();
            this.PlayerHP = new System.Windows.Forms.Label();
            this.PlayerAtt = new System.Windows.Forms.Label();
            this.PlayerDef = new System.Windows.Forms.Label();
            this.PlayerMoney = new System.Windows.Forms.Label();
            this.OponentsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OponentName = new System.Windows.Forms.Label();
            this.OponentHealth = new System.Windows.Forms.Label();
            this.OponentAtt = new System.Windows.Forms.Label();
            this.OponentDef = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.FightButton = new System.Windows.Forms.Button();
            this.ShopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Location = new System.Drawing.Point(31, 43);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(35, 13);
            this.PlayerName.TabIndex = 1;
            this.PlayerName.Text = "label2";
            // 
            // PlayerHP
            // 
            this.PlayerHP.AutoSize = true;
            this.PlayerHP.Location = new System.Drawing.Point(31, 66);
            this.PlayerHP.Name = "PlayerHP";
            this.PlayerHP.Size = new System.Drawing.Size(35, 13);
            this.PlayerHP.TabIndex = 2;
            this.PlayerHP.Text = "label2";
            // 
            // PlayerAtt
            // 
            this.PlayerAtt.AutoSize = true;
            this.PlayerAtt.Location = new System.Drawing.Point(31, 91);
            this.PlayerAtt.Name = "PlayerAtt";
            this.PlayerAtt.Size = new System.Drawing.Size(35, 13);
            this.PlayerAtt.TabIndex = 3;
            this.PlayerAtt.Text = "label2";
            // 
            // PlayerDef
            // 
            this.PlayerDef.AutoSize = true;
            this.PlayerDef.Location = new System.Drawing.Point(31, 120);
            this.PlayerDef.Name = "PlayerDef";
            this.PlayerDef.Size = new System.Drawing.Size(35, 13);
            this.PlayerDef.TabIndex = 4;
            this.PlayerDef.Text = "label2";
            // 
            // PlayerMoney
            // 
            this.PlayerMoney.AutoSize = true;
            this.PlayerMoney.Location = new System.Drawing.Point(31, 144);
            this.PlayerMoney.Name = "PlayerMoney";
            this.PlayerMoney.Size = new System.Drawing.Size(35, 13);
            this.PlayerMoney.TabIndex = 5;
            this.PlayerMoney.Text = "label2";
            // 
            // OponentsListBox
            // 
            this.OponentsListBox.FormattingEnabled = true;
            this.OponentsListBox.Location = new System.Drawing.Point(434, 43);
            this.OponentsListBox.Name = "OponentsListBox";
            this.OponentsListBox.Size = new System.Drawing.Size(244, 121);
            this.OponentsListBox.TabIndex = 6;
            this.OponentsListBox.SelectedIndexChanged += new System.EventHandler(this.OponentsListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Oponent";
            // 
            // OponentName
            // 
            this.OponentName.AutoSize = true;
            this.OponentName.Location = new System.Drawing.Point(216, 43);
            this.OponentName.Name = "OponentName";
            this.OponentName.Size = new System.Drawing.Size(35, 13);
            this.OponentName.TabIndex = 8;
            this.OponentName.Text = "label3";
            // 
            // OponentHealth
            // 
            this.OponentHealth.AutoSize = true;
            this.OponentHealth.Location = new System.Drawing.Point(216, 66);
            this.OponentHealth.Name = "OponentHealth";
            this.OponentHealth.Size = new System.Drawing.Size(35, 13);
            this.OponentHealth.TabIndex = 9;
            this.OponentHealth.Text = "label3";
            // 
            // OponentAtt
            // 
            this.OponentAtt.AutoSize = true;
            this.OponentAtt.Location = new System.Drawing.Point(216, 91);
            this.OponentAtt.Name = "OponentAtt";
            this.OponentAtt.Size = new System.Drawing.Size(35, 13);
            this.OponentAtt.TabIndex = 10;
            this.OponentAtt.Text = "label3";
            // 
            // OponentDef
            // 
            this.OponentDef.AutoSize = true;
            this.OponentDef.Location = new System.Drawing.Point(216, 120);
            this.OponentDef.Name = "OponentDef";
            this.OponentDef.Size = new System.Drawing.Size(35, 13);
            this.OponentDef.TabIndex = 11;
            this.OponentDef.Text = "label3";
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(622, 212);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 12;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // FightButton
            // 
            this.FightButton.Location = new System.Drawing.Point(532, 212);
            this.FightButton.Name = "FightButton";
            this.FightButton.Size = new System.Drawing.Size(75, 23);
            this.FightButton.TabIndex = 13;
            this.FightButton.Text = "Fight";
            this.FightButton.UseVisualStyleBackColor = true;
            this.FightButton.Click += new System.EventHandler(this.FightButton_Click);
            // 
            // ShopButton
            // 
            this.ShopButton.Location = new System.Drawing.Point(434, 212);
            this.ShopButton.Name = "ShopButton";
            this.ShopButton.Size = new System.Drawing.Size(75, 23);
            this.ShopButton.TabIndex = 14;
            this.ShopButton.Text = "Shop";
            this.ShopButton.UseVisualStyleBackColor = true;
            this.ShopButton.Click += new System.EventHandler(this.ShopButton_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 262);
            this.Controls.Add(this.ShopButton);
            this.Controls.Add(this.FightButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.OponentDef);
            this.Controls.Add(this.OponentAtt);
            this.Controls.Add(this.OponentHealth);
            this.Controls.Add(this.OponentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OponentsListBox);
            this.Controls.Add(this.PlayerMoney);
            this.Controls.Add(this.PlayerDef);
            this.Controls.Add(this.PlayerAtt);
            this.Controls.Add(this.PlayerHP);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.label1);
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.Load += new System.EventHandler(this.MainGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Label PlayerHP;
        private System.Windows.Forms.Label PlayerAtt;
        private System.Windows.Forms.Label PlayerDef;
        private System.Windows.Forms.Label PlayerMoney;
        private System.Windows.Forms.ListBox OponentsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OponentName;
        private System.Windows.Forms.Label OponentHealth;
        private System.Windows.Forms.Label OponentAtt;
        private System.Windows.Forms.Label OponentDef;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button FightButton;
        private System.Windows.Forms.Button ShopButton;
    }
}