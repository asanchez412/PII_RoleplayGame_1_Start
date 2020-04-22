using System;
using System.Collections.Generic;
using ItemAtaque;
using ItemDefensa;

namespace Elfo
{
    public class Elfo
    {

        public Elfo(string nickname, int health, int damage, int armor) 
        {
            this.Nickname = nickname;
            this.Health = health;
            this.Damage = damage;
            this.Armor = armor;
        }
        public string Nickname{ get; set; }
        private int health{ get; set; }
        private int damage{ get; set; }
        private int armor{ get; set; }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if (value <= 100 && value >=0)
                {
                    this.health = value;
                }

            } 
        }
        public int Damage 
        {
            get
            {
                return this.damage;
            }
            set 
            {
                if (value >= 0)
                {
                    this.damage = value;
                }
            }
        }
        public int Armor
        {
            get
            {
                return this.armor;
            }
            set 
            {
                if(value >= 0)
                {
                    this.armor = value;
                }
            }
        }

        //public int ObtenerValorTotalDeDaño()
        //{
          //  return Damage;
        //}
        //public int ObtenerValorTotalDeDefensa()
        //{
          //  return Armor;
        //}
        private IList<ItemAtaque> offEquip = new List<ItemAtaque>();
        private void AddStep(ItemAtaque itemAtaque)
        {
            if (offEquip.Count <= 2)
            {
                this.offEquip.Add(itemAtaque);
            }
        }

        private void RemoveStep(ItemAtaque itemAtaque)
        {
            this.offEquip.Remove(itemAtaque);
        }
        private IList<ItemDefensa> deffEquip = new List<ItemDefensa>();
        private void AddStep(ItemDefensa itemDefensa)
        {
            if (deffEquip.Count <= 5)
            {
                this.deffEquip.Add(itemDefensa);
            }
        }

        private void RemoveStep(ItemDefensa itemDefensa)
        {
            this.deffEquip.Remove(itemDefensa);
        }
        public double GetAttackValue()
        {
            double result = 0;

            foreach (ItemAtaque itemOff in this.offEquip)
            {
                result = result + itemOff.AttackValue;
            }
            return result;
        }
        public double GetDeffValue()
        {
            double result = 0;
            foreach (ItemDefensa itemDeff in this.deffEquip)
            {
                result = result + itemDeff.ArmorValue;
            }
            return result;
        }

    }
}