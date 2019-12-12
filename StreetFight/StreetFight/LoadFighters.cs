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
    public partial class LoadFighters : Form
    {
        bool FighterSelected;
        List<Fighter> Fighters;
        Fighter SelectedFighter;
        public LoadFighters()
        {
            InitializeComponent();
        }

        private void LoadFighters_Load(object sender, EventArgs e)
        {
            DataBaseOperations D = new DataBaseOperations();
            Fighters = D.ReadFighters();
            foreach (Fighter fighter in Fighters)
            {
                String toAdd = fighter.getID().ToString() + "|" + fighter.GetName() + "|" + fighter.GetHP().ToString() + "|" + fighter.GetAtt().ToString() + "|" + fighter.GetDef().ToString() + "|" + fighter.GetMoney().ToString();
                FightersListBox.Items.Add(toAdd);
            }
            FighterSelected = false;
        }

        private void SelectFighter_Click(object sender, EventArgs e)
        {
            if (FighterSelected)
            {
                String fighter = FightersListBox.GetItemText(FightersListBox.SelectedIndex);
                string[] data = fighter.Split('|');
                int Id = int.Parse(data[0]);
                foreach (Fighter fighter1 in Fighters)
                {
                    if(fighter1.getID() == Id)
                    {
                        SelectedFighter = fighter1;
                    }
                }
                StartGame();
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Form newForm = new MainMenu();
            newForm.Show();
            this.Hide();
        }

        private void FightersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FighterSelected = true;
        }

        private void StartGame()
        {
            Form newForm = new MainGame(SelectedFighter.getID());
            newForm.Show();
            this.Hide();
        }
    }
}
