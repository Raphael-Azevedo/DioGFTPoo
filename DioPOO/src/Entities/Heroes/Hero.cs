namespace DioPOO.src.Entities.Heroes{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int HP, int MP, string Weapon)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
            this.Weapon = Weapon;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public string Weapon { get; set; }

        public override string ToString()
        {
            return this.Name + ": Level: " + this.Level + " Class: " + this.HeroType + " HP: " + this.HP + " MANA: " + this.MP+" - Esta Equipado com "+this.Weapon;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com a sua " + this.Weapon;
        }
    }
}