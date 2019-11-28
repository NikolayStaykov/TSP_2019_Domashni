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
        private string DbConn = @"server=SIT3074/COURSEWORKTSP19;database=StreetFight;UID=NikolayStaykov;password=meaningoflife42";

        public void UpdateFighter(Fighter fighter)
        {
            SqlConnection NewConn = new SqlConnection(DbConn);
            string items = fighter.GetItemsInString();
            int money = fighter.GetMoney();
            string query = "UPDATE FighterData SET FighterHP = " + fighter.GetMaxHP().ToString() +
                ", FighterAttack = " + fighter.GetAtt().ToString() + ", FighterDefence = " + fighter.GetDef().ToString() +
                ", FighterItems = " + fighter.GetItemsInString() + ", Money = " + fighter.GetMoney().ToString() + "WHERE ID = " + fighter.getID().ToString() + ";";
            SqlCommand cmd = new SqlCommand(query, NewConn);
        }

        public List<Fighter> ReadFighters()
        {
            List<Fighter> fighters;
            SqlConnection NewConn = new SqlConnection(DbConn);
            NewConn.Open();
            string query = "SELECT * FROM FighterData";
            SqlCommand cmd = new SqlCommand(query, NewConn);
            SqlDataReader Dreader = new SqlDataReader();
            Dreader = cmd.ExecuteReader();
            while (Dreader.Read())
            {
                int id = int.Parse(Dreader.GetString(1));
                string name = Dreader.GetString(2);
                int health = int.Parse(Dreader.GetString(3));
                int att = int.Parse(Dreader.GetString(4));
                int def = int.Parse(Dreader.GetString(5));
                int money = int.Parse(Dreader.GetString(7));
                Fighter fighter = new Fighter(id, name, health, att, def, money);
                fighters.Add(fighter);
            }
            return fighters;
        }
        public int GetNewFighterID()
        {
            string query = "SELECT MAX(ID) FROM FighterData";
            SqlConnection NewConn = new SqlConnection(DbConn);
            SqlCommand cmd = new SqlCommand(query, NewConn);
            SqlDataReader Dreader = new SqlDataReader();
            Dreader = cmd.ExecuteReader();
            int newID = int.Parse(Dreader.GetString(1));
            newID++;
            return newID;
        }
        public void WriteFighter(Fighter fighter)
        {
            SqlConnection NewConn = new SqlConnection(DbConn);
            string items = fighter.GetItemsInString();
            int money = fighter.GetMoney();
            string query = "INSERT INTO FighterData (ID,FighterHP,FighterAttack,FighterDefence,FighterItems,Money)  VALUES(" + fighter.getID() +","+ fighter.GetMaxHP().ToString() +
                "," + fighter.GetAtt().ToString() + "," + fighter.GetDef().ToString() +
                "," + fighter.GetItemsInString() + "," + fighter.GetMoney().ToString() + ");";
            SqlCommand cmd = new SqlCommand(query, NewConn);
        }

    }
}
