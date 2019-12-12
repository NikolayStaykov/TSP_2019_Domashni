using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetFight
{
    class Fight
    {
        private Fighter Player;
        private Fighter Oponent;
        Random rand1;

        public Fight(Fighter player,Fighter oponent)
        {
            Player = player;
            Oponent = oponent;
        }
        public int CalcReward()
        {
            return (Oponent.GetHP() + Oponent.GetAtt() + Oponent.GetDef()) / 5;
        }
        public int FightSequence()
        {
            while (Player.GetHP() > 0 || Oponent.GetHP() > 0)
            {
                if (rand1.Next(0, 10) + Player.GetAtt() > Oponent.GetDef() + rand1.Next(0, 10))
                {
                    Oponent.SetHP(Oponent.GetHP() - rand1.Next(1, 4) + Player.AttackDamage());
                }
                if (rand1.Next(0, 10) + Player.GetDef() < rand1.Next(0, 10) + Oponent.GetAtt())
                {
                    Player.SetHP(Player.GetHP() - rand1.Next(1, 4) + Oponent.AttackDamage());
                }
            }
            if (Player.GetHP() < 0 && Oponent.GetHP() < 0)
            {
                return 0;
            }
            else if (Oponent.GetHP() < 0)
            {
                return 1;
            }
            else if (Player.GetHP() < 0)
            {
                return 2;
            }
            return 0;
        }
    }
}
