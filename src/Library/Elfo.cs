using System;
using System.Collections.Generic;
using ItemsDeAtaque;
using ItemsDeDefensa;
using Enanos;
using Magos;

namespace Elfos
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

        private IList<ItemAtaque> offEquip = new List<ItemAtaque>();
        private void EquipOffEquip(ItemAtaque itemAtaque)
        {
            if (offEquip.Count <= 2)
            {
                this.offEquip.Add(itemAtaque);
            }
        }

        private void RemoveOffEquip(ItemAtaque itemAtaque)
        {
            this.offEquip.Remove(itemAtaque);
        }
        private IList<ItemDefensa> deffEquip = new List<ItemDefensa>();
        private void AddDeffItem(ItemDefensa itemDefensa)
        {
            if (deffEquip.Count <= 5)
            {
                this.deffEquip.Add(itemDefensa);
            }
        }

        private void RemoveDeffItem(ItemDefensa itemDefensa)
        {
            this.deffEquip.Remove(itemDefensa);
        }
        public int GetAttackValue()
        {
            int result = this.damage;

            foreach (ItemAtaque itemOff in this.offEquip)
            {
                result = result + itemOff.AttackValue;
            }
            return result;
        }
        public int GetDeffValue()
        {
            int result = this.armor;
            foreach (ItemDefensa itemDeff in this.deffEquip)
            {
                result = result + itemDeff.ArmorValue;
            }
            return result;
        }
        public void AtacarElfo(Elfo p1)
        {
            int damage = this.GetAttackValue();

            int damageRecived = this.GetAttackValue() - p1.GetDeffValue();

            if (p1.health > 0)
            {
                p1.health = p1.health - damageRecived;
                Console.WriteLine($"El jugador {p1.Nickname} recibe {damageRecived} puntos de daño");
            }
        }
        public void AtacarEnano(Enano p1)
        {
            int damage = this.GetAttackValue();

            int damageRecived = this.GetAttackValue() - p1.GetDeffValue();

            if (p1.Health > 0)
            {
                p1.Health = p1.Health - damageRecived;
                Console.WriteLine($"El jugador {p1.Name} recibe {damageRecived} puntos de daño");
            }
        }
        public void AtacarMago(Mago p1)
        {
            int damage = this.GetAttackValue();

            int damageRecived = this.GetAttackValue() - p1.GetDeffValue();

            if (p1.Health > 0)
            {
                p1.Health = p1.Health - damageRecived;
                Console.WriteLine($"El jugador {p1.Name} recibe {damageRecived} puntos de daño");
            }
        }

    }
}