namespace DioPOO.src.Entities
{

    public class Wizard : Hero
    {
        public Wizard (string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level= Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public Wizard()
        {

        }
        public override string Attack ()
        {
          return this.Name + " Lançou Magia";
        }

        public string Attack(int Bonus)
        {
        if(Bonus > 6)
            {
                return this.Name + " Lançou magia super efetiva com bônus de ataque de " + Bonus;
            }else{
                return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
            }
        }
    }
}