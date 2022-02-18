namespace DioPOO.src.Entities.Heroes{
    public class Monk : Acolyte
    {
        public Monk(string Name, int Level, string HeroType, int HP, int MP, string Weapon) : base(Name, Level, HeroType, HP, MP, Weapon)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
            this.Weapon = Weapon;
        }

        public override string Attack()
        {
            return this.Name + " Atacou com a sua " + this.Weapon;
        }

        public string Storm()
        {
            return this.Name + " Lançou Ataque de tempestade!";
        }

        public string Foco()
        {
            return this.Name + " Lançou a Magia Foco!";
        }
    }
}