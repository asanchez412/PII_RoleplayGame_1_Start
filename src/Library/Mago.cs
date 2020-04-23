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
        public void AtacarEnano(Enano p1, LibrodeHechizos libro)
        {
            int damageReceived = 0;

            damageReceived = this.GetAttackValue() + libro.Damage - p1.GetDeffValue();

            if (damageReceived >= 0)
            {
                p1.Health = p1.Health - damageReceived;
                Console.WriteLine("El jugador {0} recibe {1} puntos de daño", p1.Name, damageReceived);
            }
            else
            {
                Console.WriteLine("El jugador {0} no recibe daño.", p1.Name);
            }
        }
        public void AtacarMago(Mago p1, LibrodeHechizos libro)
        {
            int damageReceived = 0;

            damageReceived = this.GetAttackValue()+libro.Damage - p1.GetDeffValue();

            if (damageReceived >= 0)
            {
                p1.Health = p1.Health - damageReceived;
                Console.WriteLine("El jugador {0} recibe {1} puntos de daño", p1.Name, damageReceived);
            }
            else
            {
                Console.WriteLine("El jugador {0} no recibe daño.", p1.Name);
            }
        }
        public void AtacarElfo(Elfo p1, LibrodeHechizos libro)
        {
            int damageReceived = 0;

            damageReceived = this.GetAttackValue()+libro.Damage - p1.GetDeffValue();

            if (damageReceived > 0)
            {
                p1.Health = p1.Health - damageReceived;
                Console.WriteLine("El jugador {0} recibe {1} puntos de daño", p1.Nickname, damageReceived);
            }
            else
            {
                Console.WriteLine("El jugador {0} no recibe daño.", p1.Nickname);
            }
        }
    }
}
