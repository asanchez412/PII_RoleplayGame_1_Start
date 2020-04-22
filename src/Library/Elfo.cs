using System;

namespace Elfo
{
    public class Elfo
    {

        public Elfo(string nickname, int life, int damage, int armor) 
        {
            this.Nickname = nickname;
            this.Life = life;
            this.Damage = damage;
            this.Armor = armor;
        }
        public string Nickname{get; set ;}
        private int life{get;set;}

        public int Life 
        {
            get
            {
                return this.life;
            }
            set
            {
                if (value <= 100 && value >=0)
                {
                    this.life = value;
                }

            } 
        }
        public int Damage {get ; set ;}
        public int Armor{get; set ;}

        public int ObtenerValorTotalDeDaño()
        {
            return Damage;
        }
        public int ObtenerValorTotalDeDefensa()
        {
            return Armor;
        }

    }
}