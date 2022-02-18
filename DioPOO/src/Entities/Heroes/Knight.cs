
namespace DioPOO.src.Entities.Heroes
{
    public class Knight : Swordsman
    {
        public Knight(string Name, int Level, string HeroType, int HP, int MP, string Weapon) : base(Name, Level, HeroType, HP, MP, Weapon)
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

        public string Spearstab()
        {

            return this.Name + " Lançou Estocada!";
        }

        public string BrandishSpear()
        {
            return this.Name + " Lançou Brandir Lança!";
        }
    }
}
