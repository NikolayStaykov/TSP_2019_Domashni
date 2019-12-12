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
    public partial class Shop : Form
    {
        Fighter Player;
        List<Item> Items;
        List<int> ItemPrices;
        Random r1;
        bool ItemSelected;
        public Shop(int id)
        {
            InitializeComponent();
            DataBaseOperations D = new DataBaseOperations();
            Player = D.GetFighter(id);
            PlayerName.Text = "Name: " + Player.GetName();
            PlayerHP.Text = "Health: " + Player.GetMaxHP().ToString();
            PlayerAtt.Text = "Attack: " + Player.GetMoney().ToString();
            PlayerDef.Text = "Defense: " + Player.GetDef().ToString();
            PlayerMoney.Text = "Money: " + Player.GetMoney().ToString();
            Items = D.GetItems();
            ShopItems.Items.Add("ID | Name | Health bonus | Attack bonus | Defense bonus | Price ");
            InventroryListBox.Items.Add("Name | Health bonus | Attack bonus | Defense bonus ");
            string[] PlayerItems = Player.GetItemsInString().Split('|');
            foreach(string i in PlayerItems)
            {
                foreach(Item item in Items)
                {
                    string toAdd;
                    toAdd = item.ID.ToString() + ";" + item.Name + ";" + item.HpBomus.ToString() + ";" + item.AttBonus + "" + item.DefBonus.ToString();
                    if (item.ID == int.Parse(i))
                    {
                        InventroryListBox.Items.Add(toAdd);
                    }
                    int price = r1.Next(15, 20);
                    ItemPrices.Add(price);
                    toAdd = toAdd + ";" + price.ToString();
                    ShopItems.Items.Add(toAdd);
                }
            }
            ItemSelected = false;
        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }

        private void ShopItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemSelected = true;
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Form newForm = new MainMenu();
            newForm.Show();
            this.Hide();
        }

        private void FightButon_Click(object sender, EventArgs e)
        {
            Form newForm = new MainGame(Player.getID());
            newForm.Show();
            this.Hide();
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            if(ItemSelected)
            {
                string[] ItemData = ShopItems.GetItemText(ShopItems.SelectedItem).Split(';');
                if(int.Parse(ItemData[5]) <= Player.GetMoney())
                {
                    int itemid = int.Parse(ItemData[0]);
                    foreach(Item item in Items)
                    {
                        if(item.ID == itemid)
                        {
                            if(Player.AddItem(item) == 0)
                            {
                                MessageBox.Show("Purchase sucessful!", "Shop", MessageBoxButtons.OK);
                                Player.SetMoney(Player.GetMoney() - int.Parse(ItemData[5]));
                                Form newForm = new MainGame(Player.getID());
                                newForm.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Inventory full!", "Shop", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Not enough money!", "Shop", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please select item to purchase.", "Shop", MessageBoxButtons.OK);
            }
        }
    }
}
