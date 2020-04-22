using System;

namespace ItemsDeDefensa
{
    class ItemDefensa
    {
        public ItemDefensa(string name, string description, int armorValue)
        {
            this.Name = name;
            this.Description = description;
            this.ArmorValue = armorValue;
        }
        public string Name { get; set; }

        public string Description { get; set; }

        public int ArmorValue 
        {
            get {return this.ArmorValue;}
            set
            {
                if (value < 0)
                {
                    this.ArmorValue = 0;
                }
                else
                {
                    this.ArmorValue = value;
                }
            }
        }
    }
} 