using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_3
{
    public class Monster
    {
        public Form1 form1 = new Form1();
        public int Current_HP;
        int Max_HP, MaxDamage, Mass, OMass;
        int DamageVer, HealthVer;
        int MaxCost, Cost, Summ = 0;
        int Dobytoe;
        Random rand = new Random();

        public int max_HP
        {
            get { return Max_HP; }
            set { Max_HP = value; Current_HP = value; }
        }
        public int max_mass
        {
            get { return Mass; }
            set { Mass = value; }
        }
        public int Maxdamage
        {
            get { return MaxDamage; }
            set { MaxDamage = value; }
        }
        public int damageVer
        {
            get { return DamageVer; }
            set { DamageVer = value; }
        }
        public int healthVer
        {
            get { return HealthVer; }
            set { HealthVer = value; }
        }
        public int Maxcost
        {
            get { return MaxCost; }
            set { MaxCost = value; }
        }

        public string GetData()
        {
            return $"Current_HP: {Current_HP} \nCost: {Cost} \nSumm: {Summ} \nDobytoe: {Dobytoe} \nMass: {Mass}";
        }


            public int Attack()
            {
            int shancHP = rand.Next(1, 100);
            int shancDam = rand.Next(1, 100);
            int Damage = rand.Next(0, MaxDamage);
            int count_HP = rand.Next(1, Max_HP);
            Cost = rand.Next(1, MaxCost);
            if (Current_HP > 0)
            {
                if (DamageVer > 0 && DamageVer >= shancDam)
                {
                    Current_HP -= Damage;
                    if (Current_HP <= 0)
                    {
                        Current_HP = 0;
                    }
                }
                if (HealthVer > 0 && HealthVer >= shancHP)
                {
                    Current_HP += count_HP;
                    if (Current_HP >= Max_HP)
                    {
                        Current_HP = Max_HP;
                    }
                }
            }
            return Current_HP;
            }
        public int Sell()
        {
            Summ = Dobytoe * Cost;
            Dobytoe = 0;
            return Summ;
        }
        public int Srez()
        {
            Cost = rand.Next(1, MaxCost);
            int srezan;
            srezan = rand.Next(1, 10);
            if (Current_HP == 0)
            {
                OMass = (Mass * srezan / 100);
                Mass -= OMass;
                Dobytoe += OMass;
            }
            return Dobytoe;
        }
    }
}
