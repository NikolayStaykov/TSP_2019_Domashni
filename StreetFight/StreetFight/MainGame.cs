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
    public partial class MainGame : Form
    {
        private Fighter Player;
        bool OponentSelected;
        List<Fighter> Oponents;
        Fighter SelectedOPonent;
        public MainGame(int id)
        {
            InitializeComponent();
            DataBaseOperations D = new DataBaseOperations();
            List<Fighter> Fighters = D.ReadFighters();
            foreach (Fighter fighter in Fighters)
            {
                if(id == fighter.getID())
                {
                    Player = fighter;
                }
                else
                {
                    Oponents.Add(fighter);
                    String toAdd = fighter.getID().ToString() + "|" + fighter.GetName() + "|" + fighter.GetHP().ToString() + "|" + fighter.GetAtt().ToString() + "|" + fighter.GetDef().ToString() + "|" + fighter.GetMoney().ToString();
                    OponentsListBox.Items.Add(toAdd);
                }
            }
            OponentSelected = false;
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            PlayerName.Text = "Name: " + Player.GetName();
            PlayerHP.Text = "Health: " + Player.GetMaxHP().ToString();
            PlayerAtt.Text = "Attack: " + Player.GetMoney().ToString();
            PlayerDef.Text = "Defense: " + Player.GetDef().ToString();
            PlayerMoney.Text = "Money: " + Player.GetMoney().ToString();
            OponentName.Text = "Name: ";
            OponentHealth.Text = "Health: ";
            OponentAtt.Text = "Attack: ";
            OponentDef.Text = "Defense: ";
        }

        private void OponentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String fighter = OponentsListBox.GetItemText(OponentsListBox.SelectedIndex);
            string[] data = fighter.Split('|');
            OponentName.Text = "Name: " + data[1];
            OponentHealth.Text = "Health: " + data[2];
            OponentAtt.Text = "Attack: " + data[3];
            OponentDef.Text = "Defense: " + data[4];
            OponentSelected = true;
            foreach(Fighter fighter1 in Oponents)
            {
                if(fighter1.getID() == int.Parse(data[0]))
                {
                    SelectedOPonent = fighter1;
                }
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Form newForm = new MainMenu();
            newForm.Show();
            this.Hide();
        }

        private void FightButton_Click(object sender, EventArgs e)
        {
            Fight CurrentFight = new Fight(Player, SelectedOPonent);
            int PrizeMoney = CurrentFight.CalcReward();
            int FightOutcome = CurrentFight.FightSequence();
            if (FightOutcome == 0)
            {
                //draw
                MessageBox.Show("Draw!", "Fight Results", MessageBoxButtons.OK);
            }
            else if (FightOutcome == 1)
            {
                //win
                Player.SetMoney(Player.GetMoney() + PrizeMoney);
                MessageBox.Show("Victory! \n Fight money won: " + PrizeMoney.ToString(), "Fight Results", MessageBoxButtons.OK);
            }
            else if (FightOutcome == 2)
            {
                //lose
                int MoneyLost = 0;
                MoneyLost = PrizeMoney;
                if (Player.GetMoney() < PrizeMoney)
                {
                    MoneyLost = Player.GetMoney();
                }
                Player.SetMoney(Player.GetMoney() - MoneyLost);
                MessageBox.Show("Defeat! \n Fight money lost: " + MoneyLost.ToString(), "Fight Results", MessageBoxButtons.OK);
            }
            PlayerMoney.Text = "Money: " + Player.GetMoney().ToString();
            OponentsListBox.SelectedIndex = 0;
        }

        private void ShopButton_Click(object sender, EventArgs e)
        {
            Form newForm = new Shop(Player.getID());
            newForm.Show();
            this.Hide();
        }
    }
}
