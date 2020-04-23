using System;
using System.Collections.Generic;
using ItemsDeAtaque;
using ItemsDeDefensa;
using LibroHechizo;
using Enanos;
using Elfos;


namespace Magos
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
                else if(value < 0)
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
        private void EquipOffEquip(ItemAtaque itemAtaque)
        {
            if (equipt.Count <= 2)
            {
                this.equipt.Add(itemAtaque);
            }
        }

        private void RemoveOffEquip(ItemAtaque itemAtaque)
        {
            this.equipt.Remove(itemAtaque);
        }
        private IList<ItemDefensa> dequip = new List<ItemDefensa>();
        private void AddDeffItem(ItemDefensa itemDefensa)
        {
            if (dequip.Count <= 5)
            {
                this.dequip.Add(itemDefensa);
            }
        }

        private void RemoveDeffItem(ItemDefensa itemDefensa)
        {
            this.dequip.Remove(itemDefensa);
        }

        private IList<LibrodeHechizos> equip = new List<LibrodeHechizos>();
        private void AddLibro(LibrodeHechizos librodeHechizos)
        {
            if(equip.Count <= 2)
            {
                this.equip.Add(librodeHechizos);
            }
        }
        private void RemoveLibro(LibrodeHechizos librodeHechizos)
        {
            this.equip.Remove(librodeHechizos);
        }
        public int GetAttackValue()
        {
            int resultado = 0;
            foreach (ItemAtaque itemOff in this.equipt)
            {
                resultado = resultado + itemOff.AttackValue;
            }
            foreach (LibrodeHechizos libro in this.equip)
            {
                resultado = resultado + libro.Damage;
            }
            return resultado + this.Damage;
        }
        public int GetDeffValue()
        {
            int result = 0;
            foreach (ItemDefensa itemDeff in this.dequip)
            {
                result = result + itemDeff.ArmorValue;
            }
            return result + this.Armor;
        }
        public void CurarEnano(Enano p1)
        {
            Random valor = new Random();
            int curar = valor.Next(1,15);
            if (p1.Health > 0)
            {
                p1.Health = p1.Health + curar;
                Console.WriteLine("Se cura {0} puntos al personaje {1}. Vida actual: {2}.", curar, p1.Name, p1.Health);
            } 
            else
            {
                Console.WriteLine("No se puede curar a un jugador muerto.");
            }   
        }

        public void CurarMago(Mago p1)
        {
            Random valor = new Random();
            int curar = valor.Next(1,15);
            if (p1.Health > 0)
            {
                p1.Health = p1.Health + curar;
                Console.WriteLine("Se cura {0} puntos al personaje {1}. Vida actual: {2}.", curar, p1.Name, p1.Health);
            } 
            else
            {
                Console.WriteLine("No se puede curar a un jugador muerto.");
            }   
        }
        public void CurarElfo(Elfo p1)
        {
            Random valor = new Random();
            int curar = valor.Next(1,15);
            if (p1.Health > 0)
            {
                p1.Health = p1.Health + curar;
                Console.WriteLine("Se cura {0} puntos al personaje {1}. Vida actual: {2}.", curar, p1.Nickname, p1.Health);
            } 
            else
            {
                Console.WriteLine("No se puede curar a un jugador muerto.");
            }   
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
