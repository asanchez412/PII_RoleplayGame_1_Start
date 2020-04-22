using System;

namespace LibroHechizo
{
  
    public class LibrodeHechizos
    {
        private string name;
        private int damage;

        public LibrodeHechizos(string name, int damage)
        {
            this.Name = name;
            this.Damage = damage;
        }
        public string Name { get; set; } 
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
    }
}