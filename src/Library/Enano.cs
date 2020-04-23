using System;
using System.Collections.Generic;
using ItemsDeAtaque;
using ItemsDeDefensa;
using Magos;
using Elfos;

namespace Enanos

{
    public class Enano
    {

        public Enano(string name, int health, int damage, int armor)
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
                else if (value < 0)
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
            int result = 0;

            foreach (ItemAtaque itemOff in this.offEquip)
            {
                result = result + itemOff.AttackValue;
            }
            return result + this.Damage;
        }
        public int GetDeffValue()
        {
            int result = 0;
            foreach (ItemDefensa itemDeff in this.deffEquip)
            {
                result = result + itemDeff.ArmorValue;
            }
            return result + this.Armor;
        }

        public string AtacarEnano(Enano p1)
        {
            int damageReceived = 0;

            damageReceived = this.GetAttackValue() - p1.GetDeffValue();

            if (damageReceived > 0)
            {
                string log = string.Empty;
                p1.Health = p1.Health - damageReceived;
                log = $"El jugador {p1.Name} recibe {damageReceived} puntos de daño";
                return log;
            }
            else
            {
                string log = string.Empty;
                log = $"El jugador {p1.Name} no recibe daño.";
                return log;
            }
        }
        public string AtacarMago(Mago p1)
        {
            int damageReceived = 0;

            damageReceived = this.GetAttackValue() - p1.GetDeffValue();

            if (damageReceived > 0)
            {
                string log = string.Empty;
                p1.Health = p1.Health - damageReceived;
                log = $"El jugador {p1.Name} recibe {damageReceived} puntos de daño";
                return log;
            }
            else
            {
                string log = string.Empty;
                log = $"El jugador {p1.Name} no recibe daño.";
                return log;
            }
        }
        public string AtacarElfo(Elfo p1)
        {
            int damageReceived = 0;

            damageReceived = this.GetAttackValue() - p1.GetDeffValue();

            if (damageReceived > 0)
            {
                string log = string.Empty;
                p1.Health = p1.Health - damageReceived;
                log = $"El jugador {p1.Nickname} recibe {damageReceived} puntos de daño";
                return log;
            }
            else
            {
                string log = string.Empty;
                log = $"El jugador {p1.Nickname} no recibe daño.";
                return log;
            }

        }
    }
}