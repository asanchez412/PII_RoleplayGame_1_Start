using System;
using System.Collections.Generic;
using ItemsDeAtaque;
using ItemsDeDefensa;

namespace Enano

{
    public class Enano
    {

        public Enano(string name, int damage, int health, int armor)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.Armor = armor;
        }
        public string Name { get; set; }

        public int Damage
        {
            get { return this.Damage; }
            set
            {
                if (value < 0)
                {
                    this.Damage = 0;
                }
                else
                {
                    this.Damage = value;
                }
            }
        }

        public int Health
        {
            get { return this.Health; }
            set
            {
                if (value > 100)
                {
                    this.Health = 100;
                }
                if (value < 0)
                {
                    this.Health = 0;
                }
                else
                {
                    this.Health = value;
                }
            }
        }
        public int Armor 
        {
            get { return this.Armor; }
            set
            {
                if (value < 0)
                {
                    this.Armor = 0;
                }
                else
                {
                    this.Armor = value;
                }
            }
        }
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