using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetFight
{
    class Fighter
    {
        public string Name;
        private int HP;
        private int MaxHP;
        private int Att;
        private int Def;
        private List<Item> Items;
        private int Money;
        Fighter(string N, int H, int A, int D, int M)
        {
            Name = N;
            HP = H;
            MaxHP = H;
            Att = H;
            Def = D;
            Money = M;
        }
        public void AddItem(Item I)
        {
            if (Items.Count <= 4)
            {
                Items.Add(I);
                MaxHP = MaxHP + I.HpBomus;
                Att = Att + I.AttBonus;
                Def = Def + I.DefBonus;
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
        }
        public int GetAtt()
        {
            return Att;
        }
        public void SetDef(int NewDef)
        {
            Def = NewDef;
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
        }
        public void SetMaxHP(int NewMaxHP)
        {
            MaxHP = NewMaxHP;
        }
        public int GetMaxHP()
        {
            return MaxHP;
        }
        public int AttackDamage()
        {
            if (Att - 10 < 0)
            {
                return 0;
            }
            else
            {
                return Att - 10;
            }
        }
    }
}
