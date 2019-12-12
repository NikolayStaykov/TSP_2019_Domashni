using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StreetFight
{
    class DataBaseOperations
    {
        private string DbConn = @"server=remotemysql.com;database=oY2hyCUuXz;UID=oY2hyCUuXz;password=iJLqktiah1";

        public void UpdateFighter(Fighter fighter)
        {
            SqlConnection NewConn = new SqlConnection(DbConn);
            NewConn.Open();
            string items = fighter.GetItemsInString();
            int money = fighter.GetMoney();
            string query = "UPDATE FighterData SET FighterHP = " + fighter.GetMaxHP().ToString() +
                ", FighterAttack = " + fighter.GetAtt().ToString() + ", FighterDefence = " + fighter.GetDef().ToString() +
                ", FighterItems = " + fighter.GetItemsInString() + ", Money = " + fighter.GetMoney().ToString() + "WHERE ID = " + fighter.getID().ToString() + ";";
            SqlCommand cmd = new SqlCommand(query, NewConn);
            NewConn.Close();
        }

        public List<Fighter> ReadFighters()
        {
            List<Fighter> fighters = new List<Fighter>();
            SqlConnection NewConn = new SqlConnection(DbConn);
            NewConn.Open();
            string query = "SELECT * FROM FighterData;";
            SqlCommand cmd = new SqlCommand(query, NewConn);
            SqlDataReader Dreader;
            Dreader = cmd.ExecuteReader();
            while (Dreader.Read())
            {
                int id = int.Parse(Dreader.GetString(1));
                string name = Dreader.GetString(2);
                int health = int.Parse(Dreader.GetString(3));
                int att = int.Parse(Dreader.GetString(4));
                int def = int.Parse(Dreader.GetString(5));
                string items = Dreader.GetString(6);
                int money = int.Parse(Dreader.GetString(7));
                Fighter fighter = new Fighter(id, name, health, att, def, money,items);
                fighters.Add(fighter);
            }
            NewConn.Close();
            return fighters;
        }

        public Fighter GetFighter(int FighterID)
        {
            SqlConnection NewConn = new SqlConnection(DbConn);
            NewConn.Open();
            string query = "SELECT * FROM FighterData WHERE ID = " + FighterID.ToString() + ";";
            SqlCommand cmd = new SqlCommand(query, NewConn);
            SqlDataReader Dreader;
            Dreader = cmd.ExecuteReader();
            if (Dreader.Read())
            {
                int id = int.Parse(Dreader.GetString(1));
                string name = Dreader.GetString(2);
                int health = int.Parse(Dreader.GetString(3));
                int att = int.Parse(Dreader.GetString(4));
                int def = int.Parse(Dreader.GetString(5));
                string items = Dreader.GetString(6);
                int money = int.Parse(Dreader.GetString(7));
                Fighter fighter1 = new Fighter(id, name, health, att, def, money,items);
                NewConn.Close();
                return fighter1;
            }
            else
            {
                NewConn.Close();
                return null;
            }
        }
        public int GetNewFighterID()
        {
            string query = "SELECT MAX(ID) FROM FighterData";
            SqlConnection NewConn = new SqlConnection(DbConn);
            NewConn.Open();
            SqlCommand cmd = new SqlCommand(query, NewConn);
            SqlDataReader Dreader;
            Dreader = cmd.ExecuteReader();
            int newID = int.Parse(Dreader.GetString(1));
            newID++;
            NewConn.Close();
            return newID;
        }
        public void WriteFighter(Fighter fighter)
        {
            SqlConnection NewConn = new SqlConnection(DbConn);
            string query = "INSERT INTO FighterData (ID,Name,FighterHP,FighterAttack,FighterDefence,FighterItems,Money)  VALUES(" + fighter.getID() +","+ fighter.GetName() + "," + fighter.GetMaxHP().ToString() +
                "," + fighter.GetAtt().ToString() + "," + fighter.GetDef().ToString() +
                "," + fighter.GetItemsInString() + "," + fighter.GetMoney().ToString() + ");";
            NewConn.Open();
            SqlCommand cmd = new SqlCommand(query, NewConn);
            NewConn.Close();
        }

        public List<Item> GetItems()
        {
            List<Item> Items = new List<Item>();
            SqlConnection NewConn = new SqlConnection(DbConn);
            NewConn.Open();
            string query = "SELECT * FROM ItemData;";
            SqlCommand cmd = new SqlCommand(query, NewConn);
            SqlDataReader Dreader;
            Dreader = cmd.ExecuteReader();
            while (Dreader.Read())
            {
                Item item = new Item();
                item.ID = Dreader.GetInt32(1);
                item.Name = Dreader.GetString(2);
                item.HpBomus = Dreader.GetInt32(3);
                item.AttBonus = Dreader.GetInt32(4);
                item.DefBonus = Dreader.GetInt32(5);
                Items.Add(item);
            }
            NewConn.Close();
            return Items;
        }
    }
}
