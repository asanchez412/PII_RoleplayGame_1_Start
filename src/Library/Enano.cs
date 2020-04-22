using System;

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
    }
}