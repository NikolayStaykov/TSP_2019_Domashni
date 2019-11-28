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
        private int Stats;
        private int Strength = 8;
        private int Defense = 8;
        private int Health = 8;
        private string Name;
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
        }

        private void numericUpDownForStrength_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownForStrength.Value > Strength && Stats > 0)
            {
                Strength++;
                Stats--;
                BonusStats.Text = BonusStats.Text + Stats.ToString();
            }
            else if (Stats < 6)
            {
                Strength--;
                Stats++;
                BonusStats.Text = BonusStats.Text + Stats.ToString();
            }
        }

        private void numericUpDownForDefense_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownForDefense.Value > Defense && Stats > 0)
            {
                Defense++;
                Stats--;
                BonusStats.Text = BonusStats.Text + Stats.ToString();
            }
            else if (Stats < 6)
            {
                Defense--;
                Stats++;
                BonusStats.Text = BonusStats.Text + Stats.ToString();
            }
        }

        private void numericUpDownForhealth_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownForhealth.Value > Health && Stats > 0)
            {
                Health++;
                Stats--;
                BonusStats.Text = BonusStats.Text + Stats.ToString();
            }
            else if (Stats < 6)
            {
                Health--;
                Stats++;
                BonusStats.Text = BonusStats.Text + Stats.ToString();
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            Name = NameTextBox.Text;
        }

        private void CFighter_Click(object sender, EventArgs e)
        {
            int id = D.GetNewFighterID();
            Fighter fighter = new Fighter(id,Name,Health,Strength,Defense,0);
            D.WriteFighter(fighter);
            Form MainGame = new MainGame(fighter);
            MainGame.Show();
            this.Hide();
        }
    }
}
