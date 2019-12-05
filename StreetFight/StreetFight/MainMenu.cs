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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void NewFighter_Click(object sender, EventArgs e)
        {
            Form newForm = new CreateFighter();
            newForm.Show();
            this.Hide();
        }

        private void LoadFighter_Click(object sender, EventArgs e)
        {
            Form newForm = new LoadFighters();
            newForm.Show();
            this.Hide();
        }
    }
}
