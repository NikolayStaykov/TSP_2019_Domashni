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
        public LoadFighters()
        {
            InitializeComponent();
        }

        private void LoadFighters_Load(object sender, EventArgs e)
        {
            List<Fighter> Fighters;
            DataBaseOperations D = new DataBaseOperations();
            Fighters = D.ReadFighters();
            foreach (Fighter fighter in Fighters)
            {
                FightersListBox.Items.Add(fighter.ToString());
            }
            FighterSelected = false;
        }

        private void SelectFighter_Click(object sender, EventArgs e)
        {
            String fighter = FightersListBox.GetItemText(FightersListBox.SelectedIndex);
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
    }
}
