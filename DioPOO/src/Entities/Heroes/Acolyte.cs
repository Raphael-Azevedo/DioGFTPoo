
namespace DioPOO.src.Entities.Heroes
{

    public class Acolyte : Hero
    {
        public Acolyte(string Name, int Level, string HeroType, int HP, int MP, string Weapon) : base(Name, Level, HeroType, HP, MP, Weapon)
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

        public string Heal()
        {
            return this.Name + " Lançou magia de Cura!";
        }

        public string Protect()
        {
            return this.Name + " Lançou magia de Proteção";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou magia super efetiva com bônus de ataque de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
            }
        }
    }
}