namespace StreetFight
{
    partial class Shop
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
            this.PlayerName = new System.Windows.Forms.Label();
            this.PlayerHP = new System.Windows.Forms.Label();
            this.PlayerAtt = new System.Windows.Forms.Label();
            this.PlayerDef = new System.Windows.Forms.Label();
            this.PlayerMoney = new System.Windows.Forms.Label();
            this.InventroryListBox = new System.Windows.Forms.ListBox();
            this.ShopItems = new System.Windows.Forms.ListBox();
            this.PurchaseButton = new System.Windows.Forms.Button();
            this.FightButon = new System.Windows.Forms.Button();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Location = new System.Drawing.Point(77, 32);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(35, 13);
            this.PlayerName.TabIndex = 0;
            this.PlayerName.Text = "label1";
            // 
            // PlayerHP
            // 
            this.PlayerHP.AutoSize = true;
            this.PlayerHP.Location = new System.Drawing.Point(77, 56);
            this.PlayerHP.Name = "PlayerHP";
            this.PlayerHP.Size = new System.Drawing.Size(35, 13);
            this.PlayerHP.TabIndex = 1;
            this.PlayerHP.Text = "label1";
            // 
            // PlayerAtt
            // 
            this.PlayerAtt.AutoSize = true;
            this.PlayerAtt.Location = new System.Drawing.Point(77, 80);
            this.PlayerAtt.Name = "PlayerAtt";
            this.PlayerAtt.Size = new System.Drawing.Size(35, 13);
            this.PlayerAtt.TabIndex = 2;
            this.PlayerAtt.Text = "label1";
            // 
            // PlayerDef
            // 
            this.PlayerDef.AutoSize = true;
            this.PlayerDef.Location = new System.Drawing.Point(77, 103);
            this.PlayerDef.Name = "PlayerDef";
            this.PlayerDef.Size = new System.Drawing.Size(35, 13);
            this.PlayerDef.TabIndex = 3;
            this.PlayerDef.Text = "label1";
            // 
            // PlayerMoney
            // 
            this.PlayerMoney.AutoSize = true;
            this.PlayerMoney.Location = new System.Drawing.Point(77, 127);
            this.PlayerMoney.Name = "PlayerMoney";
            this.PlayerMoney.Size = new System.Drawing.Size(35, 13);
            this.PlayerMoney.TabIndex = 4;
            this.PlayerMoney.Text = "label1";
            // 
            // InventroryListBox
            // 
            this.InventroryListBox.FormattingEnabled = true;
            this.InventroryListBox.Location = new System.Drawing.Point(80, 169);
            this.InventroryListBox.Name = "InventroryListBox";
            this.InventroryListBox.Size = new System.Drawing.Size(227, 95);
            this.InventroryListBox.TabIndex = 5;
            // 
            // ShopItems
            // 
            this.ShopItems.FormattingEnabled = true;
            this.ShopItems.Location = new System.Drawing.Point(486, 32);
            this.ShopItems.Name = "ShopItems";
            this.ShopItems.Size = new System.Drawing.Size(268, 238);
            this.ShopItems.TabIndex = 6;
            this.ShopItems.SelectedIndexChanged += new System.EventHandler(this.ShopItems_SelectedIndexChanged);
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.Location = new System.Drawing.Point(444, 318);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(75, 23);
            this.PurchaseButton.TabIndex = 7;
            this.PurchaseButton.Text = "Purchase ";
            this.PurchaseButton.UseVisualStyleBackColor = true;
            this.PurchaseButton.Click += new System.EventHandler(this.PurchaseButton_Click);
            // 
            // FightButon
            // 
            this.FightButon.Location = new System.Drawing.Point(558, 318);
            this.FightButon.Name = "FightButon";
            this.FightButon.Size = new System.Drawing.Size(75, 23);
            this.FightButon.TabIndex = 8;
            this.FightButon.Text = "Fight";
            this.FightButon.UseVisualStyleBackColor = true;
            this.FightButon.Click += new System.EventHandler(this.FightButon_Click);
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(659, 318);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(75, 23);
            this.MainMenuButton.TabIndex = 9;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.FightButon);
            this.Controls.Add(this.PurchaseButton);
            this.Controls.Add(this.ShopItems);
            this.Controls.Add(this.InventroryListBox);
            this.Controls.Add(this.PlayerMoney);
            this.Controls.Add(this.PlayerDef);
            this.Controls.Add(this.PlayerAtt);
            this.Controls.Add(this.PlayerHP);
            this.Controls.Add(this.PlayerName);
            this.Name = "Shop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Label PlayerHP;
        private System.Windows.Forms.Label PlayerAtt;
        private System.Windows.Forms.Label PlayerDef;
        private System.Windows.Forms.Label PlayerMoney;
        private System.Windows.Forms.ListBox InventroryListBox;
        private System.Windows.Forms.ListBox ShopItems;
        private System.Windows.Forms.Button PurchaseButton;
        private System.Windows.Forms.Button FightButon;
        private System.Windows.Forms.Button MainMenuButton;
    }
}