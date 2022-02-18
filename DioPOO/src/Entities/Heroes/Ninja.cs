namespace DioPOO.src.Entities.Heroes{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HP, int MP, string Weapon) : base(Name, Level, HeroType, HP, MP, Weapon)
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
            return this.Name + " Atacou com a " + this.Weapon;
        }

        public string ThrowKunai()
        {
            return this.Name + " Arremessou uma Kunai!";
        }

        public string ThrowHuumaShuriken()
        {
            return this.Name + " Arremessou uma Huuma Shuriken!";
        }
        public string FinalStrike()
        {
            return this.Name + " Lançou Ataque Mortal!";
        }
        public string LightningCrash()
        {
            return this.Name + " Lançou Descarga Elétrica!";
        }
    }
}