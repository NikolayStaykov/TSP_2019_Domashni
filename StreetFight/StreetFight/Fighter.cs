using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetFight
{
    class Fighter
    {
        private int ID;
        private string Name;
        private int HP;
        private int MaxHP;
        private int Att;
        private int Def;
        private string ItemsString;
        private int Money;
        public Fighter(int I,string N, int H, int A, int D, int M,string It)
        {
            ID = I;
            Name = N;
            HP = H;
            MaxHP = H;
            Att = H;
            Def = D;
            Money = M;
            ItemsString = It;
        }
        public int AddItem(Item I)
        {
            if(ItemsString.Length < 8)
            {
                MaxHP = MaxHP + I.HpBomus;
                Att = Att + I.AttBonus;
                Def = Def + I.DefBonus;
                ItemsString = ItemsString + "|" + I.ID.ToString();
                DataBaseOperations DB = new DataBaseOperations();
                DB.UpdateFighter(this);
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public void SetHP(int newHP)
        {
            HP = newHP;
        }
        public int GetHP()
        {
            return HP;
        }
        public void SetAtt(int NewAtt)
        {
            Att = NewAtt;
            DataBaseOperations DB = new DataBaseOperations();
            DB.UpdateFighter(this);
        }
        public int GetAtt()
        {
            return Att;
        }
        public void SetDef(int NewDef)
        {
            Def = NewDef;
            DataBaseOperations DB = new DataBaseOperations();
            DB.UpdateFighter(this);
        }
        public int GetDef()
        {
            return Def;
        }
        public int GetMoney()
        {
            return Money;
        }
        public void SetMoney(int NewMoney)
        {
            Money = NewMoney;
            DataBaseOperations DB = new DataBaseOperations();
            DB.UpdateFighter(this);
        }
        public void SetMaxHP(int NewMaxHP)
        {
            MaxHP = NewMaxHP;
            DataBaseOperations DB = new DataBaseOperations();
            DB.UpdateFighter(this);
        }
        public int GetMaxHP()
        {
            return MaxHP;
        }
        public int AttackDamage()
        {
            if (Att <= 10)
            {
                return 0;
            }
            else
            {
                return Att - 10;
            }
        }
        public string GetItemsInString()
        {
            return ItemsString;
        }
        public int getID()
        {
            return ID;
        }
        public string GetName()
        {
            return Name;
        }
    }
}
