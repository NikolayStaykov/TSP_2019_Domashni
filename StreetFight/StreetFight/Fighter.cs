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
        private int Att;
        private int Def;
        private List<Item> Items;
        public void AddItem(Item I)
        {
            if (Items.Count <= 4)
            {
                Items.Add(I);
            }
        }
        public void SetHP(int newHP)
        {
            HP = newHP;
        }
    }
}
