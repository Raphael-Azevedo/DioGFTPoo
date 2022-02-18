namespace DioPOO.src.ValueObject
{
    public class Skill
    {
        public Skill(int power)
        {
            Power = power;
        }
        public int RequiredLevel { get; set; }
        public int Power { get; set; }
        //public string Action { get; set; }
    }
}
