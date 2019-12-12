using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreetFight
{
    public partial class CreateFighter : Form
    {
        public int Stats;
        public int Strength = 8;
        public int Defense = 8;
        public int Health = 8;
        public string FighterName;
        bool NameSet;
        DataBaseOperations D = new DataBaseOperations();
        public CreateFighter()
        {
            InitializeComponent();
        }

        private void CreateFighter_Load(object sender, EventArgs e)
        {
            Stats = 6;
            numericUpDownForDefense.Value = 8;
            numericUpDownForStrength.Value = 8;
            numericUpDownForhealth.Value = 8;
            BonusStats.Text = BonusStats.Text + Stats.ToString();
            NameSet = false;
        }

        private void numericUpDownForStrength_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownForStrength.Value > Strength && Stats > 0)
            {
                Strength++;
                Stats--;
                BonusStats.Text = "Stat Points: " + Stats.ToString();
            }
            else if (numericUpDownForStrength.Value < Strength && Stats < 6)
            {
                Strength--;
                Stats++;
                BonusStats.Text = "Stat Points: " + Stats.ToString();
            }
            numericUpDownForStrength.Value = Strength;
        }

        private void numericUpDownForDefense_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownForDefense.Value > Defense && Stats > 0)
            {
                Defense++;
                Stats--;
                BonusStats.Text = "Stat Points: " + Stats.ToString();
            }
            else if (numericUpDownForDefense.Value < Defense && Stats < 6)
            {
                Defense--;
                Stats++;
                BonusStats.Text = "Stat Points: " + Stats.ToString();
            }
            numericUpDownForDefense.Value = Defense;
        }

        private void numericUpDownForhealth_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownForhealth.Value > Health && Stats > 0)
            {
                Health++;
                Stats--;
                BonusStats.Text = "Stat Points: " + Stats.ToString();
            }
            else if (numericUpDownForhealth.Value < Health && Stats < 6)
            {
                Health--;
                Stats++;
                BonusStats.Text = "Stat Points: " + Stats.ToString();
            }
            numericUpDownForhealth.Value = Health;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            FighterName = NameTextBox.Text;
            NameSet = true;
        }

        private void CFighter_Click(object sender, EventArgs e)
        {
            if (NameSet)
            {
                int id = D.GetNewFighterID();
                Fighter fighter = new Fighter(id, FighterName, Health, Strength, Defense, 0);
                D.WriteFighter(fighter);
                Form MainGame = new MainGame(id);
                MainGame.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please input a name for your fighter.", "Create Fighter", MessageBoxButtons.OK);
            }
        }
    }
}
