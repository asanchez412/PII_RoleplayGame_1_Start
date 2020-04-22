namespace ItemsDeAtaque
{
    class ItemAtaque
    {
        public ItemAtaque(string name, string description, int attackValue)
        {
            this.Name = name;
            this.Description = description;
            this.AttackValue = attackValue;
        }
        public string Name { get; set; }

        public string Description { get; set; }

        public int AttackValue 
        {
            get {return this.AttackValue;}
            set
            {
                if (value < 0)
                {
                    this.AttackValue = 0;
                }
                else
                {
                    this.AttackValue = value;
                }
            }
        }
    }
}