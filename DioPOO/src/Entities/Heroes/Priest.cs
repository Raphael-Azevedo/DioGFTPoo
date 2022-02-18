namespace DioPOO.src.Entities.Heroes{
    public class Priest : Acolyte
    {
        public Priest(string Name, int Level, string HeroType, int HP, int MP, string Weapon) : base(Name, Level, HeroType, HP, MP, Weapon)
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
            return this.Name + " Atacou com o seu " + this.Weapon;
        }

        public string Bless()
        {
            return this.Name + " Lançou Benção no grupo!";
        }

        public string HealAll()
        {
            return this.Name + " Lançou magia de cura no grupo!";
        }



    }
}