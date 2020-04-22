using System;
using System.Collections.Generic;
using ItemsDeAtaque;
using ItemsDeDefensa;
using LibroHechizo;


namespace Mago
{
        public class Mago
    {
            
        private string name;
        private int health;
        private int damage;
        private int armor;

        public string Name { get; set; } 

        public Mago(string name, int health, int damage, int armor)
            {
                this.Name = name;
                this.Health = health;
                this.Damage = damage;
                this.Armor = armor;
            }
        public int Damage 
        { 
            get{ return this.Damage; } 
            set
            {
                if(value < 0)
                {
                    this.damage = 0;
                }
                else
                {
                    this.damage = value;
                }
            } 
        }
        public int Health 
        { 
            get { return this.Health; }
            set
            {
                if(value > 100)
                {
                    this.health = 100;
                }
                if(value < 0)
                {
                    this.health = 0;
                }
                else
                {
                    this.Health = value;
                }
            }

        }

        public int Armor
        {
            get{ return this.Armor; }
            set
            {
                if(value < 0)
                {
                    this.Armor = 0;
                }
                else
                {
                    this.Armor = value;
                }
            }
        }
        private IList<ItemAtaque> equipt = new List<ItemAtaque>();
        private void AddStep(ItemAtaque itemAtaque)
        {
            if (equipt.Count <= 2)
            {
                this.equipt.Add(itemAtaque);
            }
        }

        private void RemoveStep(ItemAtaque itemAtaque)
        {
            this.equipt.Remove(itemAtaque);
        }
        private IList<ItemDefensa> dequip = new List<ItemDefensa>();
        private void AddStep(ItemDefensa itemDefensa)
        {
            if (dequip.Count <= 5)
            {
                this.dequip.Add(itemDefensa);
            }
        }

        private void RemoveStep(ItemDefensa itemDefensa)
        {
            this.dequip.Remove(itemDefensa);
        }

        private IList<LibrodeHechizos> equip = new List<LibrodeHechizos>();
        private void AddStep(LibrodeHechizos librodeHechizos)
        {
            if(equip.Count <= 2)
            {
                this.equip.Add(librodeHechizos);
            }
        }
        private void RemoveStep(LibrodeHechizos librodeHechizos)
        {
            this.equip.Remove(librodeHechizos);
        }
        public double Value()
        {
            double resultado = 0;
            foreach (ItemDefensa itemD in this.dequip)
            {
                resultado = resultado + itemD.ArmorValue;
            }
            return resultado;
        }
    }
}