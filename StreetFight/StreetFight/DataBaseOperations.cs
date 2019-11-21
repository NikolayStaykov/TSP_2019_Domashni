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

            }
        }

    }
}
