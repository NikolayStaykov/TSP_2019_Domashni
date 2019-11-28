namespace StreetFight
{
    partial class CreateFighter
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.numericUpDownForStrength = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownForDefense = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownForhealth = new System.Windows.Forms.NumericUpDown();
            this.CFighter = new System.Windows.Forms.Button();
            this.BonusStats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForhealth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Strength:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Defense:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Health";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(70, 10);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 4;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // numericUpDownForStrength
            // 
            this.numericUpDownForStrength.Location = new System.Drawing.Point(70, 36);
            this.numericUpDownForStrength.Name = "numericUpDownForStrength";
            this.numericUpDownForStrength.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownForStrength.TabIndex = 5;
            this.numericUpDownForStrength.ValueChanged += new System.EventHandler(this.numericUpDownForStrength_ValueChanged);
            // 
            // numericUpDownForDefense
            // 
            this.numericUpDownForDefense.Location = new System.Drawing.Point(70, 68);
            this.numericUpDownForDefense.Name = "numericUpDownForDefense";
            this.numericUpDownForDefense.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownForDefense.TabIndex = 6;
            this.numericUpDownForDefense.ValueChanged += new System.EventHandler(this.numericUpDownForDefense_ValueChanged);
            // 
            // numericUpDownForhealth
            // 
            this.numericUpDownForhealth.Location = new System.Drawing.Point(70, 95);
            this.numericUpDownForhealth.Name = "numericUpDownForhealth";
            this.numericUpDownForhealth.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownForhealth.TabIndex = 7;
            this.numericUpDownForhealth.ValueChanged += new System.EventHandler(this.numericUpDownForhealth_ValueChanged);
            // 
            // CFighter
            // 
            this.CFighter.Location = new System.Drawing.Point(88, 262);
            this.CFighter.Name = "CFighter";
            this.CFighter.Size = new System.Drawing.Size(127, 23);
            this.CFighter.TabIndex = 8;
            this.CFighter.Text = "Create Fighter";
            this.CFighter.UseVisualStyleBackColor = true;
            this.CFighter.Click += new System.EventHandler(this.CFighter_Click);
            // 
            // BonusStats
            // 
            this.BonusStats.AutoSize = true;
            this.BonusStats.Location = new System.Drawing.Point(13, 194);
            this.BonusStats.Name = "BonusStats";
            this.BonusStats.Size = new System.Drawing.Size(64, 13);
            this.BonusStats.TabIndex = 9;
            this.BonusStats.Text = "Stat Points: ";
            // 
            // CreateFighter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 297);
            this.Controls.Add(this.BonusStats);
            this.Controls.Add(this.CFighter);
            this.Controls.Add(this.numericUpDownForhealth);
            this.Controls.Add(this.numericUpDownForDefense);
            this.Controls.Add(this.numericUpDownForStrength);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateFighter";
            this.Text = "CreateFighter";
            this.Load += new System.EventHandler(this.CreateFighter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForhealth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.NumericUpDown numericUpDownForStrength;
        private System.Windows.Forms.NumericUpDown numericUpDownForDefense;
        private System.Windows.Forms.NumericUpDown numericUpDownForhealth;
        private System.Windows.Forms.Button CFighter;
        private System.Windows.Forms.Label BonusStats;
    }
}